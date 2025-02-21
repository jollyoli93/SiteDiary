using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBConnect;

public partial class SiteDiaryContext : DbContext
{
    public SiteDiaryContext()
    {
    }

    public SiteDiaryContext(DbContextOptions<SiteDiaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<CoinsWb> CoinsWbs { get; set; }

    public virtual DbSet<DiaryEntry> DiaryEntries { get; set; }

    public virtual DbSet<Downtime> Downtimes { get; set; }

    public virtual DbSet<LogType> LogTypes { get; set; }

    public virtual DbSet<Org> Orgs { get; set; }

    public virtual DbSet<PackageInformation> PackageInformations { get; set; }

    public virtual DbSet<ProjectInformation> ProjectInformations { get; set; }

    public virtual DbSet<SiteCb> SiteCbs { get; set; }

    public virtual DbSet<SiteInfo> SiteInfos { get; set; }

    public virtual DbSet<SiteOrg> SiteOrgs { get; set; }

    public virtual DbSet<SitePackage> SitePackages { get; set; }

    public virtual DbSet<SiteTrade> SiteTrades { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Trade> Trades { get; set; }

    public virtual DbSet<WeatherDatum> WeatherData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=jodevadm1;initial catalog=SiteDiary;trusted_connection=true;TrustServerCertificate=True;\n ",
                x => x.UseNetTopologySuite()
            );

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("PK__attachme__B74DF4E2BE34FBA8");

            entity.ToTable("attachments");

            entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");
            entity.Property(e => e.AttachmentType)
                .HasMaxLength(100)
                .HasColumnName("attachment_type");
            entity.Property(e => e.BlobStorageAddress)
                .HasMaxLength(255)
                .HasColumnName("blob_storage_address");
        });

        modelBuilder.Entity<CoinsWb>(entity =>
        {
            entity.HasKey(e => e.CbsId).HasName("PK__coins_wb__FE6B9C3F22AA2DB3");

            entity.ToTable("coins_wbs");

            entity.Property(e => e.CbsId).HasColumnName("cbs_id");
            entity.Property(e => e.WbsCode)
                .HasMaxLength(50)
                .HasColumnName("wbs_code");
        });

        modelBuilder.Entity<DiaryEntry>(entity =>
        {
            entity.HasKey(e => e.DiaryId).HasName("PK__diary_en__339232C83A2070F2");

            entity.ToTable("diary_entries");

            entity.Property(e => e.DiaryId).HasColumnName("diary_id");
            entity.Property(e => e.Activity).HasColumnName("activity");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FromDatetime)
                .HasColumnType("datetime")
                .HasColumnName("from_datetime");
            entity.Property(e => e.LogTypeId).HasColumnName("log_type_id");
            entity.Property(e => e.OrganisationId).HasColumnName("organisation_id");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .HasColumnName("photo");
            entity.Property(e => e.Problems).HasColumnName("problems");
            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.ToDatetime)
                .HasColumnType("datetime")
                .HasColumnName("to_datetime");
            entity.Property(e => e.WeatherId).HasColumnName("weather_id");
            entity.Property(e => e.WorksLocation)
                .HasMaxLength(255)
                .HasColumnName("works_location");

            entity.HasOne(d => d.LogType).WithMany(p => p.DiaryEntries)
                .HasForeignKey(d => d.LogTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__diary_ent__log_t__5EBF139D");

            entity.HasOne(d => d.Organisation).WithMany(p => p.DiaryEntries)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__diary_ent__organ__5FB337D6");

            entity.HasOne(d => d.Project).WithMany(p => p.DiaryEntries)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__diary_ent__proje__5CD6CB2B");

            entity.HasOne(d => d.Staff).WithMany(p => p.DiaryEntries)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__diary_ent__staff__5DCAEF64");

            entity.HasOne(d => d.Weather).WithMany(p => p.DiaryEntries)
                .HasForeignKey(d => d.WeatherId)
                .HasConstraintName("FK__diary_ent__weath__60A75C0F");
        });

        modelBuilder.Entity<Downtime>(entity =>
        {
            entity.HasKey(e => e.DowntimeLogId).HasName("PK__downtime__1C118E0182F3D303");

            entity.ToTable("downtime");

            entity.Property(e => e.DowntimeLogId).HasColumnName("downtime_log_id");
            entity.Property(e => e.AttachmentKey).HasColumnName("attachment_key");
            entity.Property(e => e.CbsKey).HasColumnName("cbs_key");
            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .HasColumnName("details");
            entity.Property(e => e.DowntimeHours).HasColumnName("downtime_hours");
            entity.Property(e => e.Impact)
                .HasMaxLength(255)
                .HasColumnName("impact");
            entity.Property(e => e.IssuesDelays)
                .HasMaxLength(255)
                .HasColumnName("issues_delays");
            entity.Property(e => e.LostManHours).HasColumnName("lost_man_hours");
            entity.Property(e => e.NoOfPeopleAffected).HasColumnName("no_of_people_affected");
            entity.Property(e => e.SiteKey).HasColumnName("site_key");

            entity.HasOne(d => d.AttachmentKeyNavigation).WithMany(p => p.Downtimes)
                .HasForeignKey(d => d.AttachmentKey)
                .HasConstraintName("FK__downtime__attach__3B75D760");
        });

        modelBuilder.Entity<LogType>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__log_type__9E2397E0F1186BB3");

            entity.ToTable("log_type");

            entity.Property(e => e.LogId).HasColumnName("log_id");
            entity.Property(e => e.LogType1)
                .HasMaxLength(100)
                .HasColumnName("log_type");
        });

        modelBuilder.Entity<Org>(entity =>
        {
            entity.HasKey(e => e.OrgId).HasName("PK__orgs__F6AD8012A55C4456");

            entity.ToTable("orgs");

            entity.Property(e => e.OrgId).HasColumnName("org_id");
            entity.Property(e => e.OrganisationName)
                .HasMaxLength(100)
                .HasColumnName("organisation_name");
        });

        modelBuilder.Entity<PackageInformation>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__package___63846AE83CD40F73");

            entity.ToTable("package_information");

            entity.Property(e => e.PackageId)
                .ValueGeneratedNever()
                .HasColumnName("package_id");
            entity.Property(e => e.PackageName)
                .HasMaxLength(100)
                .HasColumnName("package_name");
        });

        modelBuilder.Entity<ProjectInformation>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__project___BC799E1F41B4BE7F");

            entity.ToTable("project_information");

            entity.Property(e => e.ProjectId).HasColumnName("project_id");
            entity.Property(e => e.ProjectCode)
                .HasMaxLength(100)
                .HasColumnName("project_code");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .HasColumnName("project_name");
        });

        modelBuilder.Entity<SiteCb>(entity =>
        {
            entity.HasKey(e => e.SiteCbsId).HasName("PK__site_cbs__E71622130CA3366F");

            entity.ToTable("site_cbs");

            entity.Property(e => e.SiteCbsId).HasColumnName("site_cbs_id");
            entity.Property(e => e.CbsKey).HasColumnName("cbs_key");
            entity.Property(e => e.ProjectKey).HasColumnName("project_key");

            entity.HasOne(d => d.CbsKeyNavigation).WithMany(p => p.SiteCbs)
                .HasForeignKey(d => d.CbsKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_cbs__cbs_ke__4D94879B");

            entity.HasOne(d => d.ProjectKeyNavigation).WithMany(p => p.SiteCbs)
                .HasForeignKey(d => d.ProjectKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_cbs__projec__4E88ABD4");
        });

        modelBuilder.Entity<SiteInfo>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK__site_inf__B22FDBCA9E6A154C");

            entity.ToTable("site_info");

            entity.Property(e => e.SiteId).HasColumnName("site_id");
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .HasColumnName("site_name");
        });

        modelBuilder.Entity<SiteOrg>(entity =>
        {
            entity.HasKey(e => e.SiteOrgsId).HasName("PK__site_org__76C35F2D06939FB7");

            entity.ToTable("site_orgs");

            entity.Property(e => e.SiteOrgsId).HasColumnName("site_orgs_id");
            entity.Property(e => e.OrgKey).HasColumnName("org_key");
            entity.Property(e => e.SiteKey).HasColumnName("site_key");

            entity.HasOne(d => d.OrgKeyNavigation).WithMany(p => p.SiteOrgs)
                .HasForeignKey(d => d.OrgKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_orgs__org_k__5535A963");

            entity.HasOne(d => d.SiteKeyNavigation).WithMany(p => p.SiteOrgs)
                .HasForeignKey(d => d.SiteKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_orgs__site___5629CD9C");
        });

        modelBuilder.Entity<SitePackage>(entity =>
        {
            entity.HasKey(e => e.SitePackagesId).HasName("PK__site_pac__9C9A65CAB4FBF30F");

            entity.ToTable("site_packages");

            entity.Property(e => e.SitePackagesId).HasColumnName("site_packages_id");
            entity.Property(e => e.PackageKey).HasColumnName("package_key");
            entity.Property(e => e.SiteKey).HasColumnName("site_key");

            entity.HasOne(d => d.PackageKeyNavigation).WithMany(p => p.SitePackages)
                .HasForeignKey(d => d.PackageKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_pack__packa__59063A47");

            entity.HasOne(d => d.SiteKeyNavigation).WithMany(p => p.SitePackages)
                .HasForeignKey(d => d.SiteKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_pack__site___59FA5E80");
        });

        modelBuilder.Entity<SiteTrade>(entity =>
        {
            entity.HasKey(e => e.SiteTradesId).HasName("PK__site_tra__7094B1E5F8EE658F");

            entity.ToTable("site_trades");

            entity.Property(e => e.SiteTradesId).HasColumnName("site_trades_id");
            entity.Property(e => e.ProjectKey).HasColumnName("project_key");
            entity.Property(e => e.TradeKey).HasColumnName("trade_key");

            entity.HasOne(d => d.ProjectKeyNavigation).WithMany(p => p.SiteTrades)
                .HasForeignKey(d => d.ProjectKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_trad__proje__52593CB8");

            entity.HasOne(d => d.TradeKeyNavigation).WithMany(p => p.SiteTrades)
                .HasForeignKey(d => d.TradeKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__site_trad__trade__5165187F");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__staff__1963DD9C430315CB");

            entity.ToTable("staff");

            entity.Property(e => e.StaffId)
                .ValueGeneratedNever()
                .HasColumnName("staff_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
        });

        modelBuilder.Entity<Trade>(entity =>
        {
            entity.HasKey(e => e.TradeId).HasName("PK__trades__AAFF5BF7117EF3FF");

            entity.ToTable("trades");

            entity.Property(e => e.TradeId).HasColumnName("trade_id");
            entity.Property(e => e.TradeDescription)
                .HasMaxLength(255)
                .HasColumnName("trade_description");
        });

        modelBuilder.Entity<WeatherDatum>(entity =>
        {
            entity.HasKey(e => e.WeatherId).HasName("PK__weather___4CDA2101E16CD1F6");

            entity.ToTable("weather_data");

            entity.Property(e => e.WeatherId).HasColumnName("weather_id");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.WeatherConditions)
                .HasMaxLength(255)
                .HasColumnName("weather_conditions");
            entity.Property(e => e.WindSpeed).HasColumnName("wind_speed");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

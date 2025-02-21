using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class SiteInfo
{
    public int SiteId { get; set; }

    public string SiteName { get; set; } = null!;

    public virtual ICollection<SiteOrg> SiteOrgs { get; set; } = new List<SiteOrg>();

    public virtual ICollection<SitePackage> SitePackages { get; set; } = new List<SitePackage>();
}

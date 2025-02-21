using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class DiaryEntry
{
    public int DiaryId { get; set; }

    public int ProjectId { get; set; }

    public int StaffId { get; set; }

    public int LogTypeId { get; set; }

    public int OrganisationId { get; set; }

    public int? WeatherId { get; set; }

    public DateTime Created { get; set; }

    public DateTime? ToDatetime { get; set; }

    public DateTime? FromDatetime { get; set; }

    public string? Activity { get; set; }

    public string? Problems { get; set; }

    public string? Photo { get; set; }

    public string? Description { get; set; }

    public string? WorksLocation { get; set; }

    public int? Quantity { get; set; }

    public virtual LogType LogType { get; set; } = null!;

    public virtual Org Organisation { get; set; } = null!;

    public virtual ProjectInformation Project { get; set; } = null!;

    public virtual Staff Staff { get; set; } = null!;

    public virtual WeatherDatum? Weather { get; set; }
}

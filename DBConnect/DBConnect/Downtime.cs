using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class Downtime
{
    public int DowntimeLogId { get; set; }

    public int SiteKey { get; set; }

    public int CbsKey { get; set; }

    public TimeOnly? DowntimeHours { get; set; }

    public int? NoOfPeopleAffected { get; set; }

    public TimeOnly? LostManHours { get; set; }

    public string? IssuesDelays { get; set; }

    public string? Impact { get; set; }

    public string? Details { get; set; }

    public int? AttachmentKey { get; set; }

    public virtual Attachment? AttachmentKeyNavigation { get; set; }
}

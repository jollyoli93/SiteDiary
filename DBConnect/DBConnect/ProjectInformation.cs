using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class ProjectInformation
{
    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public string? ProjectCode { get; set; }

    public virtual ICollection<DiaryEntry> DiaryEntries { get; set; } = new List<DiaryEntry>();

    public virtual ICollection<SiteCb> SiteCbs { get; set; } = new List<SiteCb>();

    public virtual ICollection<SiteTrade> SiteTrades { get; set; } = new List<SiteTrade>();
}

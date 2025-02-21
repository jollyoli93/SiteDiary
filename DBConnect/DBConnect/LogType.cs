using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class LogType
{
    public int LogId { get; set; }

    public string LogType1 { get; set; } = null!;

    public virtual ICollection<DiaryEntry> DiaryEntries { get; set; } = new List<DiaryEntry>();
}

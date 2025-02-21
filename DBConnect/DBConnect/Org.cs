using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class Org
{
    public int OrgId { get; set; }

    public string OrganisationName { get; set; } = null!;

    public virtual ICollection<DiaryEntry> DiaryEntries { get; set; } = new List<DiaryEntry>();

    public virtual ICollection<SiteOrg> SiteOrgs { get; set; } = new List<SiteOrg>();
}

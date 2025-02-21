using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class SiteOrg
{
    public int SiteOrgsId { get; set; }

    public int OrgKey { get; set; }

    public int SiteKey { get; set; }

    public virtual Org OrgKeyNavigation { get; set; } = null!;

    public virtual SiteInfo SiteKeyNavigation { get; set; } = null!;
}

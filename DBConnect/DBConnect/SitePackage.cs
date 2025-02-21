using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class SitePackage
{
    public int SitePackagesId { get; set; }

    public int PackageKey { get; set; }

    public int SiteKey { get; set; }

    public virtual PackageInformation PackageKeyNavigation { get; set; } = null!;

    public virtual SiteInfo SiteKeyNavigation { get; set; } = null!;
}

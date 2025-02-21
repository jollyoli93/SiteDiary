using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class PackageInformation
{
    public int PackageId { get; set; }

    public string PackageName { get; set; } = null!;

    public virtual ICollection<SitePackage> SitePackages { get; set; } = new List<SitePackage>();
}

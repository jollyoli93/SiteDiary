using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class SiteCb
{
    public int SiteCbsId { get; set; }

    public int CbsKey { get; set; }

    public int ProjectKey { get; set; }

    public virtual CoinsWb CbsKeyNavigation { get; set; } = null!;

    public virtual ProjectInformation ProjectKeyNavigation { get; set; } = null!;
}

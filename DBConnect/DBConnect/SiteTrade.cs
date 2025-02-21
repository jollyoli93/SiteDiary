using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class SiteTrade
{
    public int SiteTradesId { get; set; }

    public int TradeKey { get; set; }

    public int ProjectKey { get; set; }

    public virtual ProjectInformation ProjectKeyNavigation { get; set; } = null!;

    public virtual Trade TradeKeyNavigation { get; set; } = null!;
}

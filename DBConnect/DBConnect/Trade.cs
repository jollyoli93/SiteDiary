using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class Trade
{
    public int TradeId { get; set; }

    public string TradeDescription { get; set; } = null!;

    public virtual ICollection<SiteTrade> SiteTrades { get; set; } = new List<SiteTrade>();
}

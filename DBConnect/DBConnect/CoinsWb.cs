using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class CoinsWb
{
    public int CbsId { get; set; }

    public string WbsCode { get; set; } = null!;

    public virtual ICollection<SiteCb> SiteCbs { get; set; } = new List<SiteCb>();
}

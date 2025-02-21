using System;
using System.Collections.Generic;

namespace DBConnect;

public partial class Attachment
{
    public int AttachmentId { get; set; }

    public string? AttachmentType { get; set; }

    public string? BlobStorageAddress { get; set; }

    public virtual ICollection<Downtime> Downtimes { get; set; } = new List<Downtime>();
}

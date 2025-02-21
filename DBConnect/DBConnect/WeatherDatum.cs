using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace DBConnect;

public partial class WeatherDatum
{
    public int WeatherId { get; set; }

    public DateTime DateTime { get; set; }

    public int Temperature { get; set; }

    public string? WeatherConditions { get; set; }

    public int? WindSpeed { get; set; }

    public Point Longitude { get; set; }

    public Point Latitude { get; set; }

    public virtual ICollection<DiaryEntry> DiaryEntries { get; set; } = new List<DiaryEntry>();
}

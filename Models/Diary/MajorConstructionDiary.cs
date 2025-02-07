namespace DailyDiary;

public class MajorConstructionDiary : Diary {
    private DateTime startTime;
    private DateTime endTime;
    private string org;
    private string trade;
    private string packages;

    public MajorConstructionDiary(int id, DateTime dateTime, string location, string worksType, DateTime startTime, DateTime endTime, string org, string trade, string packages) 
        : base(id, dateTime, location)
    {
        this.WorksType = worksType;
        this.StartTime = startTime;
        this.EndTime = endTime;
        this.Org = org;
        this.Trade = trade;
        this.Packages = packages;
    }

    // Properties
    public string WorksType { get; set; }

    public string Org 
    { 
        get { return org; } 
        set { org = value; } 
    }

    public string Trade 
    { 
        get { return trade; } 
        set { trade = value; } 
    }

    public string Packages 
    { 
        get { return packages; } 
        set { packages = value; } 
    }

    public DateTime StartTime
    {
        get { return startTime; }
        set { startTime = value; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
        set { endTime = value; }
    }

    public override string ToString()
    {
        return $"MajorConstruction: {WorksType}, Start: {StartTime}, End: {EndTime}, Org: {Org}, Trade: {Trade}, Packages: {Packages}";
    }

}

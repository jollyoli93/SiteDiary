namespace DailyDiary;

public class MajorConstructionDiary : Diary {
    private DateTime startTime;
    private DateTime endTime;
    public MajorConstructionDiary(int id, DateTime dateTime, string location, string worksType, DateTime startTime, DateTime endTime) : base(id, dateTime, location)
    {
        this.WorksType = worksType;
        this.StartTime = startTime;
        this.EndTime = endTime;
    }

    // Properties
    public string WorksType { get; set; }

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

    public override string toString()
    {
        return $"MajorConstruction: {WorksType}, Start: {StartTime}, End: {EndTime}";
    }
}

namespace DiaryLibrary;

public class SiteDiary : Diary {
    public SiteDiary(int id, DateTime dateTime, string location) : base(id, date_time, location)
    {
    }

    public override string setLogType(string log)
    {
        this.log_type = log;
    }
}
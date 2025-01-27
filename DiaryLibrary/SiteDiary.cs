using DiaryLibrary;

public class SiteDiary : Diary {
    public SiteDiary(int id, DateTime date_time, string entry_field) : base(id, date_time, entry_field)
    {
    }

    public override string setLogType(string log)
    {
        this.log_type = log;
    }
}
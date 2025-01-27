namespace DiaryLibrary;

public abstract class Diary 
{
    private int id;
    private DateTime date_time;
    private string location;
    private LogType log_type;
    

    public Diary (int id, DateTime dateTime, string location)
    {
        this.id = id;
        this.dateTime = dateTime;
        this.entry_field = location;
    }

    public int Id
    {
        get {return id; }
        set { this.id = value; }
    }
    
    public DateTime dateTime 
    {
        get {return dateTime;}
        set { dateTime = value; }
    }

    public string Location
    {
        get {return location;}
        set { location = value; }
    }

    public abstract string setLogType ( string log_type );

}
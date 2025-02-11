using System;
namespace DailyDiary;

public class Discussions : Diary
{
    private DateTime startTime;
    private DateTime endTime;
    private string details= "";
    private int numParticipants = 0;
    public Discussions (int id, String location, DateTime dateTime, DateTime startTime, DateTime endTime, string details, int numParticipants) 
        : base(id, dateTime, location)
    {
        this.startTime = startTime;
        this.endTime = endTime;
        this.details = details;
        this.numParticipants = numParticipants;
    }
    public string Details 
    { 
        get { return details; } 
        set { details = value; } 
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
        return $"Discussions: {location}, Start: {StartTime}, End: {EndTime}, Details {details}";
    }
}

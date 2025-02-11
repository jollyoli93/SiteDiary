using System;

namespace DailyDiary;

public class Discussions : Diary
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Details { get; set; } = "";
    public int NumParticipants { get; set; } = 0;

    public Discussions(int id, string location, DateTime dateTime, DateTime startTime, DateTime endTime, string details, int numParticipants)
        : base(id, dateTime, location) // Ensure Diary base class supports this
    {
        StartTime = startTime;
        EndTime = endTime;
        Details = details;
        NumParticipants = numParticipants;
    }

    public override string ToString()
    {
        return $"Discussions: {Location}, Start: {StartTime}, End: {EndTime}, Details: {Details}, Participants: {NumParticipants}";
    }
}

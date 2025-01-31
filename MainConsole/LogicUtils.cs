using System;
using DailyDiary;

namespace MainConsole;

public class LogicUtils
{
    public Diary majorConsDiary (int id) 
    {
        string location, description = null;
        DateTime startTime, endTime;

        Console.WriteLine("Enter location");
        location = Console.ReadLine();

        Console.WriteLine("Enter description");
        description = Console.ReadLine();

        startTime = getUserDateAndTime();
        Console.WriteLine(startTime);

        endTime = getUserDateAndTime();
        Console.WriteLine(endTime);

        return new MajorConstructionDiary(id, DateTime.UtcNow, location, description, startTime, endTime);
    }

    private DateTime getUserDateAndTime () 
    {
        Console.WriteLine("Enter date in format YYYY,MM,DD");
        var date = Console.ReadLine();

        Console.WriteLine("Enter time in format 0,0,0");
        var time = Console.ReadLine();

        var dateTime = date + "'" + time;

        DateTime validDateTime;
        DateTime.TryParse(dateTime, out validDateTime);

        return validDateTime; 
    }
}

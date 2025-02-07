using System;
using DailyDiary;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MainConsole;

public class LogicUtils
{
    public Diary majorConsDiary (int id) 
    {
        string location, activity, org, packages, trade = null;
        DateTime startTime, endTime;

        Console.WriteLine("Enter Start Date");
        startTime = getUserDateAndTime();
        Console.WriteLine(startTime);

        Console.WriteLine("Enter End Date");
        endTime = getUserDateAndTime();
        Console.WriteLine(endTime);

        Console.WriteLine("Enter organisation");
        org = Console.ReadLine();
        
        Console.WriteLine("Enter package");
        packages = Console.ReadLine();        

        Console.WriteLine("Enter trade");
        trade = Console.ReadLine();

        Console.WriteLine("Enter location");
        location = Console.ReadLine();

        Console.WriteLine("Enter activity");
        activity = Console.ReadLine();

        return new MajorConstructionDiary(id, DateTime.UtcNow, location, activity, startTime, endTime, org, trade, packages);
    }

    private DateTime getUserDateAndTime () 
    {
        Console.WriteLine("Enter date in format DD/MM/YYYY");
        var dateInput = Console.ReadLine();

        Console.WriteLine("Enter time in format HH:MM:SS (e.g. 14:30:00):");
        var timeInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dateInput) || string.IsNullOrWhiteSpace(timeInput))
            {
                Console.WriteLine("Invalid Date/Time");
                return DateTime.MinValue;
            }

        try 
        {  
            return ParseDateTime(dateInput, timeInput);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing date/time: {ex.Message}");
            return DateTime.MinValue;
        }

    }

    public DateTime ParseDateTime (String dateInput,String time) {
        int[] parsedDateTime =  dateInput.Split('/').Select(int.Parse).ToArray();
        int[] parsedTime = time.Split(':').Select(int.Parse).ToArray();

        Console.WriteLine(parsedDateTime[0] + " " +  parsedDateTime[1]  + " " + parsedDateTime[2]);

        DateTime date = new DateTime(parsedDateTime[2], parsedDateTime[1], parsedDateTime[0], parsedTime[0], parsedTime[1], parsedTime[2] );

        return date;
    }
}


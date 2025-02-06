using System;
using DailyDiary;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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


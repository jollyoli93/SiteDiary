using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MainConsole;

public static class LogicUtils
{
    public static DateTime ParseDateTime (String dateInput,String time) {
        int[] parsedDateTime =  dateInput.Split('/').Select(int.Parse).ToArray();
        int[] parsedTime = time.Split(':').Select(int.Parse).ToArray();

        Console.WriteLine(parsedDateTime[0] + " " +  parsedDateTime[1]  + " " + parsedDateTime[2]);

        DateTime date = new DateTime(parsedDateTime[2], parsedDateTime[1], parsedDateTime[0], parsedTime[0], parsedTime[1], parsedTime[2] );

        return date;
    }
}


namespace EFCoreAccess;

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DailyDiary;


    public class DiaryContext : DbContext
    {
        public DbSet<Diary> DiaryEntries { get; set; }  // Renamed property to correct pluralization

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=TutorialDB; Trusted_Connection=True;")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }
    }



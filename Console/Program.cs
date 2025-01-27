using System.Runtime.InteropServices.Marshalling;
using DailyDiary;

Diary siteDiary = new MajorConstructionDiary(1, DateTime.Now, "Manchester", "Excavation", DateTime.Now, DateTime.Now);

Console.WriteLine(siteDiary.toString());

using System;
using System.Runtime.InteropServices.Marshalling;
using DailyDiary;
using MainConsole;

namespace MainConsole;

public class DiaryLogic
{
    // Diary siteDiary = new MajorConstructionDiary(1, DateTime.Now, "Manchester", "Excavation", DateTime.Now, DateTime.Now);
    //Console.WriteLine(siteDiary.toString());
    Diary diary = null;
    LogicUtils logicUtil = new LogicUtils();


    int idCount = 0;

    public void SelectOptions ()
        {
            bool flag = true;
            do 
            {
                string response = null;

                Console.WriteLine("------------------------");
                Console.WriteLine("     Site Diary");
                Console.WriteLine("------------------------");
                Console.WriteLine();
                Console.WriteLine("Please select from the below options:");
                Console.WriteLine("[1] Major Construction Activity");
                Console.WriteLine("[2] Issues & Delays");
                Console.WriteLine("[3] Deliveries");
                Console.WriteLine("[4] Discussions");
                Console.WriteLine("[q] Quit");


                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        logicUtil.majorConsDiary(idCount);
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("No value");
                        break;
                }
            } while (flag);
    }
}


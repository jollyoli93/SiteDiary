using System;
using System.Net;
using DailyDiary;


namespace DailyDiary;

public class DiaryFactory
{
    public static Diary Create(DiaryMethod diaryType, int id)
    {
        switch(diaryType)
        {
            case MajorDiary:
                return DiaryOptions.MajorDiaryOption(id);
            case Discussions:
                return DiaryOptions.DiscussionOption(id);
            default:
                throw new NotSupportedException(
                    $"Not supported type {diaryType}"
                );
        }
    }
}

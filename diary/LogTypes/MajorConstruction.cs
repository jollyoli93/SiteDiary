namespace DiaryLibrary;


public MajorConstruction : LogType
{
    private string worksType;
    private Date startTime;
    private Date endTime;s

    public MajorConstruction(string worksType) 
    {
        this.worksType = worksType;
    }
}
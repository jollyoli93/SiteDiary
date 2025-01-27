namespace DailyDiary
{
    public abstract class Diary
    {
        private int id;
        private DateTime date_time;
        private string location;
        
        public Diary(int id, DateTime dateTime, string location)
        {
            this.id = id;
            this.date_time = dateTime;
            this.location = location;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DateTime
        {
            get { return date_time; }
            set { date_time = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public abstract string toString ();
    }
}
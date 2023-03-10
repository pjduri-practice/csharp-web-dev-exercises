namespace Classes
{
    public class Course
    {
        public string Title { get; set; }
        public double Credits { get; set; }
        public List<string> DaysOfWeek { get; set; }
        public Dictionary<string, int> Books { get; set; }
        public List<Student> StudentRoster { get; set; }

        public Course(string title, double credits, List<string> daysOfWeek, Dictionary<string, int> books, List<Student> studentRoster)
        {
            Title = title;
            Credits = credits;
            DaysOfWeek = daysOfWeek;
            Books = books;
            StudentRoster = studentRoster;
        }

    }
}

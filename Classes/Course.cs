using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Course
    {
        public string Instructor { get; set; }
        public string Subject { get; set; }
        public List<Student> Students { get; set; }

        public Course (string instructor, string subject)
        {
            this.Instructor = instructor;
            this.Subject = subject;
            Students = new List<Student> ();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanner.Utilities
{
    class Semester
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string semesterName { get; set; }
        public List<Course> courses { get; set; }

        
        public Semester()
        {
            this.startDate = new DateTime();
            this.endDate = new DateTime();
            this.semesterName = "";
            this.courses = new List<Course>();
        }
        public Semester(DateTime startDate, DateTime endDate, string semesterName, List<Course> courses)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.semesterName = semesterName;
            this.courses = courses;
        }
    }
}

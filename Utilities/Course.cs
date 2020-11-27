using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;


namespace StudentPlanner.Utilities
{
    class Course
    {
        public string courseName { get; set; }
        public string sectionName { get; set; }
        public string courseOutline { get; set; }
        public Color color { get; set; }
        public List<Assessment> assessments { get; set; }
        public List<CourseTime> courseTimes { get; set; }
        public List<Staff> staff { get; set; }

        public Course()
        {
            this.courseName = "";
            this.sectionName = "";
            this.courseOutline = "";
            this.color = new Color();
            this.assessments = new List<Assessment>();
            this.courseTimes = new List<CourseTime>();
            this.staff = new List<Staff>();
        }

        public Course(string courseName, string sectionName, string courseOutline, Color color, List<Assessment> assessments, List<CourseTime> courseTimes, List<Staff> staff)
        {
            this.courseName = courseName;
            this.sectionName = sectionName;
            this.courseOutline = courseOutline;
            this.color = color;
            this.assessments = assessments;
            this.courseTimes = courseTimes;
            this.staff = staff;

        }


    }
}

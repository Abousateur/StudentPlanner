using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanner.Utilities
{
    class CourseTime
    {
        public enum CourseTypes
        {
            Lecture,
            Tutorial,
            Lab
        }
        public CourseTypes courseType { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string location { get; set; }
        public string zoomLink { get; set; }
        public Staff teacher { get; set; }

        public CourseTime()
        {
            this.courseType = new CourseTypes();
            this.startTime = new DateTime();
            this.endTime = new DateTime();
            this.location = "";
            this.zoomLink = "";
            this.teacher = new Staff();
        }

        public CourseTime(CourseTypes courseType, DateTime startTime, DateTime endTime, string location, string zoomLink, Staff teacher)
        {
            this.courseType = courseType;
            this.startTime = startTime;
            this.endTime = endTime;
            this.location = location;
            this.zoomLink = zoomLink;
            this.teacher = teacher;
        }


    }
}

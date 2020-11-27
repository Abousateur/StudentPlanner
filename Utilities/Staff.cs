using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanner.Utilities
{
    class Staff
    {
        public enum TeacherTypes
        {
            Teacher,
            TA
        }
        public TeacherTypes teacherType { get; set; }
        public string teacherName { get; set; }
        public DateTime officeHourStart { get; set; }
        public DateTime officeHourEnd { get; set; }
        public string email { get; set; }

        public Staff()
        {
            this.teacherType = new TeacherTypes();
            this.teacherName = "";
            this.officeHourStart = new DateTime();
            this.officeHourEnd = new DateTime();
            this.email = "";
        }

        public Staff(TeacherTypes teacherType, string teacherName, DateTime officeHourStart, DateTime officeHourEnd, string email)
        {
            this.teacherType = teacherType;
            this.teacherName = teacherName;
            this.officeHourStart = officeHourStart;
            this.officeHourEnd = officeHourEnd;
            this.email = email;
        }

    }
}

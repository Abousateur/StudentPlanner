using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanner.Utilities
{
    class Assessment
    {
        public enum AssesmentTypes
        {
            Assignment,
            Exam,
            Demo,
            Project,
        }
        public string name { get; set; } 
        public DateTime dueDate { get; set; }
        public double percentage { get; set; }
        public string description { get; set; }
        public AssesmentTypes assesmentType { get; set; }

        public Assessment()
        {
            this.name = "";
            this.dueDate = new DateTime();
            this.percentage = 0.0;
            this.description = "";
            this.assesmentType = new AssesmentTypes();
        }

        public Assessment(string name, DateTime dueDate, double percentage, string description, AssesmentTypes assesmentType)
        {
            this.name = name;
            this.dueDate = dueDate;
            this.percentage = percentage;
            this.description = description;
            this.assesmentType = assesmentType;
        }
        
    }
}

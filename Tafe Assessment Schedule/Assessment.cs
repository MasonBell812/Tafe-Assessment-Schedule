using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafe_Assessment_Schedule
{
    internal class Assessment
    {
        //Properties
        public string Unit { get; set; }
        public string AT { get; set; }
        public DateTime Date { get; set; }
        public bool Resubmit { get; set; }
        public bool Completed { get; set; }
        public string Description { get; set; }

        //Constructor method
        public Assessment(string unit, string at, DateTime date, bool resubmit, bool completed)
        {
            Unit = unit;
            AT = at;
            Date = date;
            Resubmit = resubmit;
            Completed = completed;
            Description = "No description.";
        }
        public Assessment(string unit, string at, DateTime date, bool resubmit, bool completed, string description)
        {
            Unit = unit;
            AT = at;
            Date = date;
            Resubmit = resubmit;
            Completed = completed;
            Description = description;
        }

        //Formats values to CSV
        public string ToCSVString()
        {
            return Unit + "," + AT + "," + Date.ToString() + "," 
                 + Resubmit.ToString() + "," + Completed.ToString() + "," + Description;

        }
    }
}

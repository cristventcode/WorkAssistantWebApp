using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLibrary
{
    public class WorkDay
    {
        public WorkDay()
        {
            WorkLoad = new List<Task>();
        }
        public int WorkDayId { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public List<Task> WorkLoad { get; set; }

        public string Day { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
    }
}

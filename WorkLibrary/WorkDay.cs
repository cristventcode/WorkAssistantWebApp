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
            WorkLoad = new List<StockTask>();
        }
        public int WorkDayId { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public List<StockTask> WorkLoad { get; set; }
        public string Day { get; set; }
        public string Date { get; set; }
        public bool Active { get; set; }
        public string Comments { get; set; }
    }
}

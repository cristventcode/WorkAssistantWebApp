using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkLibrary
{
    public class StockTask
    {
        [Required]
        public int StockTaskId { get; set; }
        [Required]
        public int WorkDayId { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string ManufactLot { get; set; }
        public string OurLot { get; set; }
    }
}

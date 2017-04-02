using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkLibrary
{
    public class StockItem
    {
        [Required]
        public int StockItemId { get; set; }
        [Required]
        public int WorkDayId { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public Product Product { get; set; }
    }
}

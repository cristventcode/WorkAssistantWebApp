using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkLibrary
{
    public class StockTask : Task
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public Product Product { get; set; }
    }
}

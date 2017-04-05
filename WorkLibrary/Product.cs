using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkLibrary
{
    public class Product
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string MlnCurrent { get; set; }
        public string MlnPrevious { get; set; }
        public string OurLot { get; set; }
        public string Category { get; set; }
    }
}

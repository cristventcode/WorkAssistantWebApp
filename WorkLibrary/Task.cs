using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkLibrary
{
    public class Task
    {
        [Required]
        public int TaskId {get; set;}
        public string Title { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Comment { get; set; }
    }
}

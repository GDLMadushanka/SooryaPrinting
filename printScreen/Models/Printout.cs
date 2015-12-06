using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printScreen.Models
{
    class Printout:Work
    {
        public String Size { get; set; }
        public bool IsColour { get; set; }
        public int Quantity { get; set; }
        public String Printer { get; set; }
    }
}

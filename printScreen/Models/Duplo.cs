using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printScreen.Models
{
    public class Duplo:Work
    {
        public String Size { get; set; }
        public int Quantity { get; set; }
        public bool IsColourA4 { get; set; }
        public bool IsSingleSide { get; set; }
    }
}

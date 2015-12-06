using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printScreen.Models
{
    public class PhotoCopy:Work
    {
        public String Size { get; set; }
        public int Quantity { get; set; }
        public bool IsColour { get; set; }
        public bool ISSingleSide { get; set; }
    }
}

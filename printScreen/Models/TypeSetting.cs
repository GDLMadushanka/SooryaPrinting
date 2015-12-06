using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printScreen.Models
{
    public class TypeSetting:Work
    {
        public String Size { get; set; }
        public bool IsSinhala { get; set; }
        public int Pages { get; set; }
        public String  FileName { get; set; }
    }
}

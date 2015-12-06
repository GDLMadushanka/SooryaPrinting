using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printScreen.Models
{
    public class Work
    {
        public int WorkId { get; set; }
        public DateTime Date_Time { get; set; }
        public float Amount { get; set; }
        public float PaidAmount { get; set; }
        public int CustomerID { get; set; }
        public String Owner { get; set; }
        public int TableIndex { get; set; }
    }
}

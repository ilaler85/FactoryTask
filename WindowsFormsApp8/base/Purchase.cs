using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Purchase
    {
        public int id_purchase { get; set; }
        public Factory factory { get; set; }
        public Suppler suppler { get; set; }
        public int sum { get; set; }
        public DateTime date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Ingredient
    {
        public int id_ingredient { get; set; }
        public String name { get; set; }
        public int unit_price { get; set; }
        public Suppler suppler { get; set; }

    }
}

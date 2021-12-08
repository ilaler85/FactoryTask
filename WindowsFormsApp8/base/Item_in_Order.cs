using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Item_in_Order
    {
        public int id_item { get; set; }
        public Purchase purchase { get; set; }
        public Ingredient ingredient { get; set; }
        public int count { get; set; }
    }
}

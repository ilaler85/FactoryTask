using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Purchase_of_goods
    {
        public int id_purchase_of_goods { get; set; }
        public int id_factory { get; set; }
        public int id_client { get; set; }
        public DateTime Acceptance_date;
        public DateTime Execution_date;
        public int id_destination { get; set; }
         

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Suppler
    {
        public int id_suppler { get; set; }
        public String INN { get; set; }
        public String Phonr { get; set; }
        public String eMail { get; set; }
        public Address address { get; set; }
    }
}

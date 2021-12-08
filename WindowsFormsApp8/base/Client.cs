using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Client
    {
        public int id_client { get; set; }
        public String eMail { get; set; }
        public String phone { get; set; }
        public String FIO { get; set; }
        public Address address { get; set; }
    }
}

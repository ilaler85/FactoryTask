using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Workshop
    {
        public int id_workshop { get; set; }
        public String Name { get; set; }
        public Factory Factory { get; set; }
        public int temperature { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp8.UserControls;

namespace WindowsFormsApp8
{
    public class Factory
    {
        public int id_factory { get; set; }
        public string Name { get; set; }
        public int Square { get; set; }

        public Address address { get; set; }
        public string addressName { get { return address.SCC; } }
    
        public Owner owner { get; set; }
        public string ownerFIO { get { return owner.FIO; } }
        
        public int? opening_year { get; set; }

    }
}

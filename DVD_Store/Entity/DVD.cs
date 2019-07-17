using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store.Entity
{
    public class DVD
    {
        public int DVDNum { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public bool RentalState { get; set; }
    }
}

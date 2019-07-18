using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store.Entities
{
    public class Rental
    {
        public string CusId { get; set; }
        public string DVDNum { get; set; }
        public DateTime RentDate { get; set; }
    }
}

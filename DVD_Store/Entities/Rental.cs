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

        public string DvdNum { get; set; }
        
        public string DvdName { get; set; }

        public DateTime RentalDate { get; set; }


        public override string ToString()
        {
            string ment = $"CusID : {CusId}\n RentalDate : {RentalDate.ToShortDateString()}";
            return ment;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store.Entities
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }

        public bool IsRegistCustomer(List<Customer> customers, string cusId)
        {
            //cus = customers.Select(x => x.ID).Where(x => x.Equals(cusId)).Any();

            var cus = customers.Select(x => x.ID).Any(x => x.Equals(cusId));

            return cus;
        }

        public override string ToString()
        {
            return $"ID : {ID}\nName : {Name}\nPhoneNum : {PhoneNum}";
        }

        public Customer GetCustomer(List<Customer> customers, string cusId)
        {
            var query = from x in customers
                        where x.ID.Equals(cusId)
                        select x;

            return query.FirstOrDefault();

        }
    }
}

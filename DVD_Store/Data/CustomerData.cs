using DVD_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store.Data
{
    public class CustomerData
    {
        private List<Customer> customers = new List<Customer>();
       
        public void AddCustomer()
        {
            //회원가입
            Console.WriteLine("--회원 가입--");
            string cusId = null;
            string name = null;
            string phoneNum = null;

            var customer = new Customer();

            //아이디 중복 체크
            while (true)
            {
                Console.Write("아이디 : ");
                cusId = Console.ReadLine();

                if (customer.IsRegistCustomer(customers, cusId))
                {
                    Console.WriteLine("존재하는 아이디입니다");
                    Console.WriteLine("다시 입력해 주세요");
                }
                else
                    break;
            }

            Console.Write("이름 : ");
            name = Console.ReadLine();
            Console.Write("폰 번호 : ");
            phoneNum = Console.ReadLine();

            customer.ID = cusId;
            customer.Name = name;
            customer.PhoneNum = phoneNum;

            customers.Add(customer);
            
            Console.WriteLine("회원 가입 완료!");
            Console.ReadLine();

        }

        public void SearchCustomer()
        {
            string cusId = null;
            Console.WriteLine("---회원 조회---");
            Console.Write("조회 할 회원 ID : ");
            cusId = Console.ReadLine();

            Customer customer = new Customer();
            customer = customer.GetCustomer(customers, cusId);
            
            if(customer == null)
            {
                Console.WriteLine("없는 회원 입니다.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(customer);
            Console.ReadLine();
        }

        internal void UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        internal void DeleteCustomer()
        {
            throw new NotImplementedException();
        }

        public void PrintAllCusInfo()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

using DVD_Store.Entities;
using System;
using System.Collections.Generic;

namespace DVD_Store.Data
{
    public class CustomerData
    {
        private List<Customer> _customers = new List<Customer>();
       
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

                if (customer.IsRegistCustomer(_customers, cusId))
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

            _customers.Add(customer);
            
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
            customer = customer.GetCustomer(_customers, cusId);
            
            if(customer == null)
            {
                Console.WriteLine("없는 회원 입니다.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine(customer);
            Console.ReadLine();
        }

        public void UpdateCustomer()
        {
            //현재 수정은 전화번호만 가능하게
            string cusId = null;
            Console.WriteLine("--회원 수정--");
            Console.Write("수정 할 회원 ID : ");

            //겹치는 부분이기 때문에 함수로 빼도 될거같다.
            cusId = Console.ReadLine();

            Customer customer = new Customer();
            customer = customer.GetCustomer(_customers, cusId);

            if (customer == null)
            {
                Console.WriteLine("없는 회원 입니다.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"{customer.ID} 님");
            Console.Write("수정 할 전화번호 : ");
            string phonNum = null;
            phonNum =  Console.ReadLine();
            customer.PhoneNum = phonNum = null;

            Console.WriteLine("수정 완료!");
            Console.ReadLine();
        }

        public void DeleteCustomer()
        {
            string cusId = null;
            Console.WriteLine("--회원 삭제--");
            Console.Write("삭제 할 회원 ID : ");

            //겹치는 부분이기 때문에 함수로 빼도 될거같다.
            cusId = Console.ReadLine();

            Customer customer = new Customer();
            customer = customer.GetCustomer(_customers, cusId);

            if (customer == null)
            {
                Console.WriteLine("없는 회원 입니다.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"{customer.ID} 님");
            Console.Write("정말 삭제 하시겠습니까? (Y/N) ");
            string answer = null;
            answer = Console.ReadLine();
            while (true)
            {
                if (answer.Equals("y") || answer.Equals("Y"))
                {
                    _customers.Remove(customer);
                    Console.WriteLine("삭제 완료!");
                    Console.ReadLine();
                    break;
                }
                else if (answer.Equals("n") || answer.Equals("N"))
                    break;
                else
                    Console.WriteLine("Y 혹은 N 만 선택해주세요");
            }
        }

        public void PrintAllCusInfo()
        {
            foreach (var customer in _customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

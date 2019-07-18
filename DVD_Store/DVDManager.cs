using DVD_Store.Data;
using DVD_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store
{
    enum CusMenu {CusAdd,CusInfo,CusUpdate,CusDelete,CusPrintAll };
    public class DVDManager
    {
       // private List<Customer> cusTomers = new List<Customer>(); //고객 관리.
        private CustomerData customerData = new CustomerData(); //고객 관리.
        private List<DVD> dvds = new List<DVD>(); //DVD관리.
        private List<Rental> rentals = new List<Rental>();//대여관리.


        public void CustomerAccess()
        {

            while (true)
            {
                
                //고객 메뉴 출력
                Menu.CusMainMenu();
                //고객 메뉴 입력
                var num = int.Parse(Console.ReadLine());

                //1. 회원가입
                //2. 회원정보
                //3. 회원수정 우선은 폰 번호만
                //4. 회원삭제
                //5. 전체 회원 출력.
                //6. 메인 메뉴.
                if (num == 1)
                    customerData.AddCustomer();
                else if (num == 2)
                    customerData.SearchCustomer();
                else if (num == 3)
                    customerData.UpdateCustomer();
                else if (num == 4)
                    customerData.DeleteCustomer();
                else if (num == 5)
                    customerData.PrintAllCusInfo();
                else if (num == 6)
                    break;
                
            }
        }

        public void DVDAccess()
        {
            throw new NotImplementedException();
        }

        public void RentalAccess()
        {
            throw new NotImplementedException();
        }
    }
}

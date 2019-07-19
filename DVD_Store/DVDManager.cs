using DVD_Store.Data;
using DVD_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store
{
    enum CusMenu 
    {CusAdd = 1,CusInfoSearch,CusUpdate,CusDelete,CusPrintAll,MainMenu }
    enum DVDMenu 
    {
        AddDvd = 1,SearchDvdInfo,
        UpdateDVd,
        DeleteDvd,RentalDvd,
        PrintAllDvd, GetBackDvd,MainMenu
    }

    enum RentalMenu
    {
        Rental,
        GetBackDvd,
        SearchDVDRentalInfo,
        SearchCusRentalInfo,
        MainMenu
    }
    
    public class DVDManager
    {
       // private List<Customer> cusTomers = new List<Customer>(); //고객 관리.
       //private List<DVD> dvds = new List<DVD>(); //DVD관리.
       //private List<Rental> rentals = new List<Rental>();//대여조회 관리.
       
       private CustomerData customerData = new CustomerData(); //고객 관리.
       private DVDData dvdData = new DVDData();//DVD관리
       private RentalData rentalData 
           = new RentalData();//대여조회 관리
       
       
        public void CustomerAccess()
        {

            while (true)
            {
                
                //고객 메뉴 출력
                Menu.CusMainMenu();
                //고객 메뉴 입력
                var num = int.Parse(Console.ReadLine());
                //1. 회원가입
                if (num == (int)CusMenu.CusAdd)
                    customerData.AddCustomer();
                //2. 회원정보
                else if (num == (int)CusMenu.CusInfoSearch)
                    customerData.SearchCustomer();
                //3. 회원수정 우선은 폰 번호만
                else if (num == (int)CusMenu.CusUpdate)
                    customerData.UpdateCustomer();
                //4. 회원삭제
                else if (num == (int)CusMenu.CusDelete)
                    customerData.DeleteCustomer();
                //5. 전체 회원 출력.
                else if (num == (int)CusMenu.CusPrintAll)
                    customerData.PrintAllCusInfo();
                //6. 메인 메뉴.
                else if (num == (int)CusMenu.MainMenu)
                    break;
                
            }
        }

        public void DVDAccess()
        {
            while (true)
            {
                //DVD 메뉴 오픈
                Menu.DVDMainMenu();
                //DVD 메뉴 입력
                Console.Write(">> ");
                var num = int.Parse(Console.ReadLine());
                //1.DVD 등록
                if (num == (int) DVDMenu.AddDvd)
                    dvdData.AddDvd();
                //2.DVD 조회
                else if (num == (int) DVDMenu.SearchDvdInfo)
                    dvdData.SearchDvd();
                //3.DVD 수정
                else if (num == (int) DVDMenu.UpdateDVd)
                    dvdData.UpdateDvd();
                //4.DVD 삭제
                else if (num == (int) DVDMenu.DeleteDvd)
                    dvdData.DeleteDvd();
               
                //5.전체 DVD 정보 출력
                else if (num == (int) DVDMenu.PrintAllDvd)
                    dvdData.PrintAllDvd();
                //6. 메인메뉴
                else if (num == (int) DVDMenu.MainMenu)
                    break;
            }
        }

        public void RentalAccess()
        {
           //메뉴 오픈
           Menu.RentalMainMenu();
           //메뉴 선택
           var num = int.Parse(Console.ReadLine());

           while (true)
           {
               //1.대여
               if (num == (int) RentalMenu.Rental)
                   rentalData.RentDvd(customerData.GetCustomers(),dvdData.GetDvds());
               //2.반납
               else if (num == (int) RentalMenu.GetBackDvd)
                   rentalData.GetBackDvd(customerData.GetCustomers(), dvdData.GetDvds());
               //3.해당 DVD 대여 이력 조회
               else if (num == (int) RentalMenu.SearchDVDRentalInfo)
                   rentalData.SearchDVDRentlaInfo(dvdData.GetDvds());
               //4.회원의 DVD 대여 이력 조회
               else if (num == (int) RentalMenu.SearchCusRentalInfo)
                   rentalData.SearchCusRentalInfo(customerData.GetCustomers());
               //5.메인메뉴
               else if (num == (int) RentalMenu.MainMenu)
                   break;
           }

           
        }
    }
}

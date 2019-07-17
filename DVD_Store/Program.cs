using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store
{
    class Program
    {
        enum MainMenu { Customer =1,DVD,Rental,Exit};
        static void Main(string[] args)
        {
            //가게 오픈
            var dvdManager = new DVDManager();
            var menu = new Menu();// 스태틱으로 만들까 고민.
            //메뉴 출력
            while(true)
            {
                Menu.MainMenu();
                Console.Write(">> ");
                var num = int.Parse(Console.ReadLine());

                if (num == MainMenu.Customer) dvdManager.CustomerAccess();
                else if (num == MainMenu.DVD) dvdManager.DVDAccess();
                else if (num == MainMenu.Rental) dvdManager.RentalAccess();
                else if (num == MainMenu.Exit) Environment.Exit(0);

                Console.Clear();
            }
            //메뉴 입력
            
            //1. 고객
            //고객 메뉴 출력.
            //2. DVD
            //DVD 메뉴 출력.
            //3. 대여
            //대여 메뉴 출력.
            //4. 종료
        }
    }
}

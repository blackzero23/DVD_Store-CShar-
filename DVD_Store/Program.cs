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
          
            while(true)
            {
                //메뉴 출력
                Menu.MainMenu();
                Console.Write(">> ");
                //메뉴 입력
                var num = int.Parse(Console.ReadLine());

                if (num == (int)MainMenu.Customer) dvdManager.CustomerAccess();  //1. 고객
                else if (num == (int)MainMenu.DVD) dvdManager.DVDAccess(); //2.DVD
                else if (num == (int)MainMenu.Rental) dvdManager.RentalAccess(); //3.대여
                else if (num == (int)MainMenu.Exit) break; //4.종료

                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("프로그램을 종료 합니다!");
          
            
        }
    }
}

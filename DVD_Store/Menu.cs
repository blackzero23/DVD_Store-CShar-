using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.Clear(); //화면 깨끗하게 만들기.
            Console.WriteLine("---메뉴---");
            Console.WriteLine("1.고객 관리");
            Console.WriteLine("2.DVD 관리");
            Console.WriteLine("3.대여 관리");
            Console.WriteLine("4.종 료");
        }

        public static void CusMainMenu()
        {
            Console.Clear(); //화면 깨끗하게 만들기.
            Console.WriteLine("---메뉴---");
            Console.WriteLine("1.회원 가입");
            Console.WriteLine("2.회원 정보 조회");
            Console.WriteLine("3.회원 수정");
            Console.WriteLine("4.회원 삭제");
            Console.WriteLine("5.전체 회원 출력.");
            Console.WriteLine("6.메인 메뉴");
        }

        public static void DVDMainMenu()
        {
            Console.Clear(); //화면 깨끗하게 만들기.
            Console.WriteLine("---메뉴---");
            Console.WriteLine("1.DVD 등록");
            Console.WriteLine("2.DVD 정보 조회");
            Console.WriteLine("3.DVD 수정");
            Console.WriteLine("4.DVD 삭제");
            Console.WriteLine("5.전체 DVD 정보 출력.");
            Console.WriteLine("6.메인 메뉴");
        }
    }
}
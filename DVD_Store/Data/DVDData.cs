using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD_Store.Entities;

namespace DVD_Store.Data
{
    

    public class DVDData
    {
        private List<DVD> _dvds = new List<DVD>(); 
        
        public void DVDAdd()
        {
            DVD dvd = new DVD();
            Console.WriteLine("---DVD등록---");
            while (true)
            {
                Console.Write("등록 번호 : ");
                var dvdNum = Console.ReadLine();
                //null 체크 해야됨.
                if (DVD.IsRegistDVD(_dvds,dvdNum))
                {
                    Console.WriteLine("등록되어있는 번호 입니다.");
                    Console.WriteLine("다시 입력해주세요.");
                    continue;
                }

                dvd.DVDNum = dvdNum;
               
                break;
            }


            Console.Write("DVD 이름 : ");
            var name = Console.ReadLine();
            dvd.Name = name;

            //장르 선택 함수.
            dvd.Genre = DVD.SelectGenre();
            dvd.RentalState = true;
            
            _dvds.Add(dvd);

            Console.WriteLine("DVD 등록 완료.");
            Console.ReadLine();
        }

        public void DVDSearch()
        {
            DVD dvd = new DVD();
            Console.Write("조회 할 DVD 등록 번호 : ");
            var dvdNum = Console.ReadLine();
            //dvd = _dvds.Select(x => x).Where(x => x.DVDNum.Equals(dvdNum)).FirstOrDefault();
            
            dvd = _dvds.Select(x => x).FirstOrDefault(x => x.DVDNum.Equals(dvdNum));
            if (dvd == null)
            {
                Console.WriteLine("등록되어있지 않습니다.");
                return;
            }

            Console.WriteLine(dvd);
            Console.ReadLine();
        }

        /// <summary>
        /// 현재 DVD 제목만 수정 가능.
        /// </summary>
        public void DVDUpdate()
        {
            DVD dvd = new DVD();
            Console.Write("수정 할 DVD 등록번호 : ");
            var dvdNum = Console.ReadLine();
            
            dvd = _dvds.Select(x => x).FirstOrDefault(x => x.DVDNum.Equals(dvdNum));
            if (dvd == null)
            {
                Console.WriteLine("등록되어있지 않습니다.");
                return;
            }

            string dvdName = Console.ReadLine();

            dvd.Name = dvdName;
            Console.WriteLine("수정 완료!");
            Console.ReadLine();
        }

        public void DVDDelete()
        {
            DVD dvd = new DVD();
            Console.Write("삭제 할 DVD 등록번호 : ");
            var dvdNum = Console.ReadLine();
            
            dvd = _dvds.Select(x => x).FirstOrDefault(x => x.DVDNum.Equals(dvdNum));
            if (dvd == null)
            {
                Console.WriteLine("등록되어있지 않습니다.");
                return;
            }

            _dvds.Remove(dvd);
            Console.WriteLine("해당 DVD 제거 완료!");
            Console.ReadLine();
        }

        public void DVDPrintAll()
        {
            foreach (var dvd in _dvds)
            {
                Console.WriteLine(dvd);
            }
        }
    }
}
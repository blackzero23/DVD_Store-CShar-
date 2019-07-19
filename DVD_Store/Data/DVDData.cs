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
                Console.WriteLine("등록 번호 : ");
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


            Console.WriteLine("DVD 이름 : ");
            var name = Console.ReadLine();
            dvd.Name = name;

            //장르 선택 함수.
            dvd.Genre = DVD.SelectGenre();
            dvd.RentalState = true;
            
            _dvds.Add(dvd);

            Console.WriteLine("DVD 등록 완료.");
        }

        public void DVDSearch()
        {
            throw new NotImplementedException();
        }

        public void DVDUpdate()
        {
            throw new NotImplementedException();
        }

        public void DVDDelete()
        {
            throw new NotImplementedException();
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
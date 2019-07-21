using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD_Store.Entities;

namespace DVD_Store.Data
{
    public class RentalData
    {
        private List<Rental> _rentalDatas = new List<Rental>();

        public void RentDvd(List<Customer> _customers, List<DVD> _dvds)
        {
            Customer cus = new Customer();

            Console.Write("회원 ID : ");
            var cusId = Console.ReadLine();

            cus = _customers.Select(x => x).FirstOrDefault(x => x.ID.Equals(cusId));


            //cus = _customers.Select(x => x).Where(x => x.ID.Equals(cusId)).FirstOrDefault();

            //cus = customers[0];

            if (cus == null)
            {
                Console.WriteLine("등록되어있지 않은 회원 입니다.");
                return;
            }

            DVD dvd = new DVD();
            Console.Write("대여 할 DVD 등록번호 : ");
            var dvdNum = Console.ReadLine();

            dvd = _dvds.Select(x => x).FirstOrDefault(x => x.DVDNum.Equals(dvdNum));

            if (dvd == null)
            {
                Console.WriteLine("등록되어있지 않은 DVD 입니다.");
                return;
            }

            if (dvd.RentalState == false)
            {
                Console.WriteLine("대여 중인 DVD입니다. ");
                return;
            }

            dvd.RentalState = false;

            Rental rental = new Rental();
            rental.CusId = cus.ID;
            rental.DvdNum = dvd.DVDNum;
            rental.DvdName = dvd.Name;
            //현재 날짜아니면 
            rental.RentalDate = DateTime.Today;

            _rentalDatas.Add(rental);
            //직접 입력하는식으로
            //30일 이상 유효 날짜 검사 해야됨.
            //            Console.Write("대여날짜(ex 20190719 :");
            //            string rentData = Console.ReadLine();
            //            rental.RentalDate = DateTime.ParseExact(rentData, "yyyyMMdd", null);


            Console.WriteLine("대여 완료!");
            Console.ReadLine();
        }

        public void GetBackDvd(List<Customer> _customers, List<DVD> _dvds)
        {
            DVD dvd = new DVD();
            Console.Write("반납 할 DVD 등록번호 : ");
            var dvdNum = Console.ReadLine();

            dvd = _dvds.Select(x => x).FirstOrDefault(x => x.DVDNum.Equals(dvdNum));

            if (dvd == null)
            {
                Console.WriteLine("등록되어있지 않습니다.");
                return;
            }

            if (dvd.RentalState)
            {
                Console.WriteLine("반납 불가능한 DVD 입니다.");
                return;
            }

            dvd.RentalState = true;
            Console.WriteLine("반납 완료!");
            Console.ReadLine();
        }

        public void SearchDVDRentlaInfo(List<DVD> _dvds)
        {
            string dvdId = null;
            Console.Write("이력 조회 하실 DVD :");
            dvdId = Console.ReadLine();

            DVD dvd = new DVD();

            dvd = _dvds.Select(x => x).FirstOrDefault(x => x.DVDNum.Equals(dvdId));

            //var query = _dvds.Select(x => x).Where(x => x.DVDNum.Equals(dvdId)).FirstOrDefault();

            if (dvd == null)
            {
                Console.WriteLine("등록 되지 않은 DVD 입니다.");
                return;
            }
            //var rentals = new List<Rental>();

            var rentals = _rentalDatas.Select(x => x).Where(x => x.DvdNum.Equals(dvdId));

            foreach (var rental in rentals)
            {
                Console.WriteLine(rental);
            }

            Console.ReadLine();

        }

        public void SearchCusRentalInfo(List<Customer> cutomers)
        {
            throw new NotImplementedException();
        }
    }
}
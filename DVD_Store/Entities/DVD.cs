using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Store.Entities
{
    public class DVD
    {
        public enum DVDGenres
        {
            Romantic = 1,
            Mello,
            Action,
            Comedy
        }
        
        public string DVDNum { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        ///<summary>
        /// 랜탈 가능 하면 ture 불가능 하면 false
        /// </summary>
        public bool RentalState { get; set; }

        public static string SelectGenre()
        {
            Console.WriteLine("---DVD 장르 선택---");
            var genres = Enum.GetValues(DVDGenres.Action.GetType());
            foreach (var genre in genres)
                Console.WriteLine(genre);
            int genreNum = int.Parse(Console.ReadLine());

            if (genreNum == (int) DVDGenres.Romantic)
                return DVDGenres.Romantic.ToString();
            else if (genreNum == (int) DVDGenres.Mello)
                return DVDGenres.Mello.ToString();
            else if (genreNum == (int) DVDGenres.Action)
                return DVDGenres.Action.ToString();
            else if (genreNum == (int) DVDGenres.Comedy)
                return DVDGenres.Comedy.ToString();

            return null;
        }

        public override string ToString()
        {
            string rental = RentalState ? "대여가능" : "대여중";
            string ment = $"--- DVD정보 ---\n 등록번호 : {DVDNum}\n이름 : {Name}\n 장르 : {Genre}\n대여상태 : {rental}";
            return ment;
        }

        public static bool IsRegistDVD(List<DVD> dvds,string dvdNum)
        {
            return dvds.Select(x => x.DVDNum).Any(x => x.Equals(dvdNum));
        }
    }
}

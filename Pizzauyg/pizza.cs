using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzauyg
{
    internal class pizza : Ipizza
    {

        public string boyut { get; set; }
        public string kenar { get; set; }
        public string malzeme { get; set; }
        public int malzemeadedi { get; set; }
        public bool icecek { get; set; }
        public bool tatli { get; set; }

        decimal _malzemeucreti = 10m;
        decimal _icecekucreti = 75m;
        decimal _tatliucreti = 200m;
        decimal mintutar = 300m;
        public string siparistutari()
        {
            decimal toplamTutar = 0m;
            if (kenar == "İnce Kenar")
            {
                toplamTutar += 50;
            }
            else if (kenar == "Normal Kenar")
            {
                toplamTutar += 75;
            }
            else if (kenar == "Kalın Kenar")
            {
                toplamTutar += 100;
            }

            if (boyut == "Küçük")
            {
                toplamTutar += 50;
            }
            else if (boyut == "Orta")
            {
                toplamTutar += 100;
            }
            else if (boyut == "Büyük")
            {
                toplamTutar += 150;
            }

            toplamTutar += _malzemeucreti * malzemeadedi;

            if (icecek)
            {
                toplamTutar += _icecekucreti;
            }

            if (tatli)
            {
                toplamTutar += _tatliucreti;
            }
            if (toplamTutar < 300)
            {
                throw new Exception("minimum sipariş ücreti 300 tl olmalıdır");
            }
            else
            {
                string icecekmesaj = string.Empty;
                string tatlimesaj = string.Empty;
                if (icecek)
                {
                    icecekmesaj = "İçecek seçildi ";
                }
                else
                {
                    icecekmesaj = "içecek seçilmedi:";
                }
                if (tatli)
                {
                    tatlimesaj = "Tatlı seçildi ";
                }
                else
                {
                    tatlimesaj = "Tatlı seçimi yapılmadı";
                }
                return "kenar tipi : " + kenar + "\n boyut : " +
                    boyut + "\n malzemeler : " +
                    malzeme + "\n içecek seçimi : " +
                    icecekmesaj + "\n tatli : " +
                    tatlimesaj + "\n Toplam tutar : " +
                    toplamTutar;
            }
        }



    }
}

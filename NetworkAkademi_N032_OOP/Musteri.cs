using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N032_OOP
{
    class Musteri
    {
        public string TcKimlik;
        public string Isim;
        public string Soyisim;
        public int Cinsiyet;//717770001 : Bay - 717770002 : Bayan

        public Musteri()
        {

        }
        public Musteri(string tcKimlik)
        {
            TcKimlik = tcKimlik;
        }

        public Musteri(string tcKimlik, string isim) : this(tcKimlik)
        {
            Isim = isim;
        }

        public Musteri(string tcKimlik, string isim, string soyisim) : this(tcKimlik, isim)
        {
            Soyisim = soyisim;
        }

        public Musteri(string tcKimlik, string isim, string soyisim, int cinsiyet) : this(tcKimlik, isim, soyisim)
        {
            Cinsiyet = cinsiyet;
        }
        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDataBase(TcKimlik);
            return kontrol;
        }

        private bool MusteriKontrolDataBase(string tcKimlikNumarasi)
        {
            //database gidilir müsterinin tckimliknumarasına göre daha önce kayıt var mı kontrol edilir
            return true;
        }

    }



    
}

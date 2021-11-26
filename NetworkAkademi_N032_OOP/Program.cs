using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N032_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç sınıfı inceleme

            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyat = 28000; 
            A1.SatisFiyat = 32000; 
            A1.MaxIndirimTutar = 1500;
            A1.FiyatAta(31000);
            A1.Fiyat = 35000;
            A1.BilgileriGoruntule();

            Arac A2 = new Arac();


            #endregion
            //Musteri M1 = new Musteri();
            Musteri M1 = new Musteri("12345678901", "Fatih");
            M1.TcKimlik = "12345678901";
            M1.Isim = "Erdem";
            M1.Soyisim = "Atilla";
            M1.Cinsiyet = 717770001;

            Musteri M2 = M1;
            M2.Isim = "Fatih";
            M2.TcKimlik = "10987654321";

            bool musteriKontrol = M1.MusteriKontrol();
            Console.WriteLine(musteriKontrol);

            ///classlardan nesne bu şekilde new kelimesi ile türetilir.

            Fruit meyve1 = new Fruit();
            meyve1.FruitName = "Bu bir Elmadır!!";
            meyve1.MeyveRengi = "Kırmızı";
            meyve1.OlusturulmaTarihi = DateTime.Now;

            Fruit meyve2 = new Fruit();
            meyve2.FruitName = "Bu bir Elmadır!!";
            meyve2.MeyveRengi = "Kırmızı";
            meyve2.OlusturulmaTarihi = DateTime.Now;




            //Arac bmw = new Arac("bmw", "320");
            //Arac mercedes = new Arac("mercedes", "maybach", 2020);
            //bmw.SatisFiyat = 555005;

            //bmw.MaxIndirimTutar = 200000;
            //bmw.FiyatAta(456000);
            //Console.WriteLine(bmw.Marka);
            //Console.WriteLine(bmw.Model);
            //Console.WriteLine(bmw.Fiyat);

            //Console.WriteLine(mercedes.Marka);
            //Console.WriteLine(mercedes.Model);
            //Console.WriteLine(mercedes.ModelYil);


            Console.ReadKey();
        }
    }
}

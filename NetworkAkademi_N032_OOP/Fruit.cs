using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N032_OOP
{
    class Fruit
    {

        /*
         * Class sınıf demektir. Nesneyi ifade eder.C#da classlar bir namespace içinde olmalıdır.
         * herhangi bir erişim belirleyicisi almassa class default olarak internal seviyededir 
         * private : özel
         * public : genel 
         * internal : sadece bulunduğu projede yani bulunduğu namespace ulaşabilir
         * classlar içinde metotlar barındırabilir
         * classlar içinde özellikler barındırabilir
         * 
         * özellik property --> ingiliz anahtarı
         * Property nasıl yazılır?
         * 
         */

        public string FruitName { get; set; }
        public string MeyveRengi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;


        //private string fruitName;
        //private string meyveRengi;
        //private DateTime olusturulmaTarihi;

        //public string FruitName { get => fruitName; set => fruitName = value; }
        //public string MeyveRengi { get => meyveRengi; set => meyveRengi = value; }
        //public DateTime OlusturulmaTarihi { get => olusturulmaTarihi; set => olusturulmaTarihi = value; } = DateTime.Now;
    }
}

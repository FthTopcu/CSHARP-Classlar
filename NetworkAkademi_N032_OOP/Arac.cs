using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N032_OOP
{
    class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public int YakitTip;
        public int VitesTip;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;

        public Arac() { }
        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
        }
        public Arac(string _marka, string _model, int _modelYil): this(_marka, _model)
        {
            ModelYil = _modelYil;
        }

        public Arac(string marka, string model, int modelYil, decimal km) : this(marka, model, modelYil)
        {
            Km = km;
        }

        public void BilgileriGoruntule()
        {
            Console.WriteLine("Marka {0} - Model {1} - Model Yıl {2} - Fiyat {3}", Marka, Model, ModelYil,Fiyat);
        }

        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if (_fiyat < fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girisi.");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat güncellendi.");
            }
        }
    }
}

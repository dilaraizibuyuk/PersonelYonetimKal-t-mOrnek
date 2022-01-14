using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimKalıtımOrnek
{
    class MuhendisYonetim:PersonelYonetim
    {
        private string _bolum;
        private int _maas;


        public int maas
        {
            get { return _maas; }
            set
            {
                if (_bolum == "Bilgisayar Mühendisliği")
                {
                    _maas = value + 500;

                    Console.WriteLine("Maaşınıza 500 tl zam yapılmıştır.Yeni maaşınız:" + _maas);
                }
                else
                {
                    _maas = value - 300;
                    Console.WriteLine("Maaşınızdan 300 tl kesinti yapılmıştır.Yeni maaşınız" + _maas);
                }
            }
        }

        public string bolum
        {
            get { return _bolum; }
            set
            {
                _bolum = value;
            }
        }
        public void personelBilgileriniGetir()
        {
            Console.WriteLine("Mühendisin Adı:" + ad);
            Console.WriteLine("Mühendis Soyadı: " + soyad);
            Console.WriteLine("Mühendis No:" + no);
            Console.WriteLine("Mühendis Bölümü:" + bolum);
            Console.WriteLine("Mühendis Maaşı:" + maas);
            Console.WriteLine("--------------------------------------------------");
        }

    
}
}

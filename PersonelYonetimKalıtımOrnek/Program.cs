using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelYonetimKalıtımOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            MuhendisYonetim muhendisyonetim = new MuhendisYonetim() { ad = "Ece", soyad = "Okur", no = 1456, bolum = "Bilgisayar Mühendisliği", maas = 7000 };
            muhendisyonetim.personelBilgileriniGetir();
            MuhendisYonetim muhendisyonetim1 = new MuhendisYonetim() { ad = "Olgu", soyad = "Çöl", no = 1234, bolum = "Kimya Mühendisliği", maas = 9000 };
            muhendisyonetim1.personelBilgileriniGetir();
            Console.ReadLine();


        }
    }
}

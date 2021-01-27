using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri { Ad = "ZEHRA ", Soyad = "ALKAN ", Id = 1 };
            Musteri m2 = new Musteri { Ad = "BULUT ", Soyad = "ARAS ", Id = 2 };
            Musteri m3 = new Musteri { Ad = "BÜŞRA ", Soyad = ". ", Id = 3 };
            MusteriManager m = new MusteriManager();

            m.Ekle(m1);
            m.Ekle(m2);
            m.Ekle(m3);
            m.Listele();
            m.Sil(m1);
          
        }
    }
}

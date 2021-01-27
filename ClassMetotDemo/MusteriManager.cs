using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri m)
        {
            Console.WriteLine("Müşteri adı" + m.Ad + "soyadı:" + m.Soyad + "adlı müşteri eklendi");
        }

        public void Listele()
        {
            Console.WriteLine("Müşteri listelendi");

        }
        public void Sil(Musteri m)
        {
            Console.WriteLine(m.Ad+" adlı "+m.Soyad+" soyadlı müşterinin silme islemi başarılı ");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo_
{
    class MusteriManager
    {
        public void Add(Musteri musteriler)
        {
            Console.WriteLine("Tebrikler,Müşteri Eklendi : " + musteriler.Id);
        }
        public void Update(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Güncellendi : " + musteriler.Id);
        }
        public void Delete(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Silindi : " + musteriler.Id);
        }
    }
}

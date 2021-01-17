using System;

namespace ClassMethodDemo_
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.Id = 1;
                musteri1.Adi = "Duygu";
                musteri1.Soyadi = "Pahlı";

                Musteri musteri2 = new Musteri();
                musteri2.Id = 2;
                musteri2.Adi = "Hüseyin Can";
                musteri2.Soyadi = "Pahlı";

                Musteri musteri3 = new Musteri();
                musteri3.Id = 3;
                musteri3.Adi = "Saime";
                musteri3.Soyadi = "Pahlı";

                Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

                foreach (Musteri musteri in musteriler)
                {
                    Console.WriteLine("musteri.Id");
                    Console.WriteLine("musteri.Adi");
                    Console.WriteLine("musteri.Soyadi");
                    Console.WriteLine("--------------");
                }

                Console.WriteLine("-------Add---------");

                MusteriManager musteriManager = new MusteriManager();
                musteriManager.Add(musteri1);
                musteriManager.Add(musteri2);
                musteriManager.Add(musteri3);

                Console.WriteLine("---------Update--------------");


                MusteriManager musteriManager1 = new MusteriManager();
                musteriManager1.Update(musteri1);
                musteriManager1.Update(musteri2);
                musteriManager1.Update(musteri3);

                Console.WriteLine("---------Delete--------------");


                MusteriManager musteriManager2 = new MusteriManager();
                musteriManager2.Delete(musteri1);
                musteriManager2.Delete(musteri2);
                musteriManager2.Delete(musteri3);

                Console.WriteLine("---------Tamamlandı------------");


            }


        }
    }

}
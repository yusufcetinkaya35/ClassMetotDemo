using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Name = "Yusuf";
            musteri1.Surname = "Cetinkaya";
            musteri1.Id = 25;

            musteri2.Name = "Erdoğan";
            musteri2.Surname = "Arslanoğulları";
            musteri2.Id = 35;

            musteri3.Name = "Necip Fazıl";
            musteri3.Surname = "Kısakürek";
            musteri3.Id = 69;

            Console.WriteLine("--------------- Müşteri Ekleme Alanı ---------------");
            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri1);
            musteriManager1.Ekle(musteri2);
            musteriManager1.Ekle(musteri3);

            Console.WriteLine("\n--------------- Müşteri Silme Alanı ---------------");

            musteriManager1.Sil(musteri1);

            Console.WriteLine("\n--------------- Müşteri Listeleme Alanı ---------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager1.Listele(musteriler);

            Console.WriteLine();

            Console.WriteLine(musteriler.Count() + " Adet Müşteri Listelendi.");
        }
    }

}
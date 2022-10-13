using System;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteriler)
        {
            Console.WriteLine(musteriler.Id + " " + musteriler.Name + " " + musteriler.Surname + " isimli müşteri sisteme eklendi");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
                Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.Surname);
        }

        public void Sil(Musteri musteriler)
        {
            Console.WriteLine(musteriler.Id + " " + musteriler.Name + " " + musteriler.Surname + " isimli müşteri sistemden silindi");
        }
  
    }
}
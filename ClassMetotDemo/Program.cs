using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "10000";
            musteri1.Namesurname = "Ulaş Can Bakioğlu";
            musteri1.Age = 21;
            musteri1.Job = "Student";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "10001";
            musteri2.Namesurname = "Engin Demiroğ";
            musteri2.Age = 35;
            musteri2.Job = "Software Developer";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "1002";
            musteri3.Namesurname = "Murat Can Çıkla";
            musteri3.Age = 25;
            musteri3.Job = "Teacher";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager customermanager = new MusteriManager();
            foreach (Musteri musteri in musteriler)
            {
                customermanager.Add(musteri.Id, musteri.Namesurname);
                customermanager.List(musteri.Id, musteri.Namesurname);
                customermanager.Sil(musteri.Id, musteri.Namesurname);
                Console.WriteLine("İşlem tamamlanmıştır.");
            }
        }
    }
}

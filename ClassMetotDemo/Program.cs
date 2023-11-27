using ClassMetotDemo;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        MusteriManager musteriManager = new MusteriManager();
        Musteri musteri = new Musteri();
        musteri.Ad = "Emrah";
        musteri.Soyad = "OKSUZ";
        musteri.Id = 61;
        musteri.Tel = "454545454545";
        Console.WriteLine("--------------------------");
        musteriManager.MusteriEkle(musteri);
        Console.WriteLine("--------------------------");
        Console.ReadKey();
    }
}
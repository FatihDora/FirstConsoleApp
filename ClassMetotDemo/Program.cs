using ClassMetotDemo;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        MusteriManager musteriManager = new MusteriManager();

        Musteri musteri1 = new Musteri();
        musteri1.Id = 1;
        musteri1.Ad = "Fatih";
        musteri1.Soyad = "Dora";

        musteriManager.Add(musteri1);
        foreach (Musteri mus in musteriManager.GetList())
        {
            Console.WriteLine(mus.Ad);
        }
        //musteriManager.Remove(musteri1);

        foreach (Musteri mus in musteriManager.GetList())
        {
            Console.WriteLine(mus.Ad);
        }
    }
}
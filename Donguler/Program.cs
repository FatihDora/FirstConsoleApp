using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlagıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Java";
            string kurs5 = "Pyton";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlagıç için temel kurs", "Java", "Pyton", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("For bitti ->");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("Sayfa sonu- footer");
        }
    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kursu";
            string kurs2 = "Programlamaya başlangıç kursu";
            string kurs3 = "java";
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirme Kursu", 
                "Programlamaya başlangıç kursu",
                "Java","Python" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}

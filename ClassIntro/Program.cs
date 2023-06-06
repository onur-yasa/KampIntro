using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Nasuh";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.KusrAdi = "c#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;
            

            Kurs kurs2 = new Kurs();
            kurs2.KusrAdi = "Java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;
          

            Kurs kurs3 = new Kurs();
            kurs3.KusrAdi = "Python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KusrAdi+":"+kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KusrAdi + ":" + kurs.Eğitmen);
            }
        }
    }

    class Kurs
    {
        public string KusrAdi { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}

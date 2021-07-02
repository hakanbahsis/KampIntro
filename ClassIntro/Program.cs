using System;
using System.Reflection.Metadata;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "hakan";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hakan Bahşiş";
            kurs1.IzlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Baran ";
            kurs2.IzlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Barış ";
            kurs3.IzlenmeOranı = 55;

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.Egitmen +" İzlenme Oranı %"+kurs.IzlenmeOranı );
                
            }

            Console.ReadLine();
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}

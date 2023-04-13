using System.IO;
using System.Text;
namespace HelloWorld
{
    struct Chi
    {
        public string Nev;
        public DateTime Szul_Datum;
        public int Suly;
        public string Simi;

        public Chi(string sor)
        {
            var dbok = sor.Split(";");
            this.Nev = dbok[0];
            this.Szul_Datum = DateTime.Parse(dbok[1]);
            this.Suly = int.Parse(dbok[2]);
            this.Simi = dbok[3];
        }
    }
    class Program
    {
        static List<Chi> Chi_List = new List<Chi>();
        static void Main(string[] args)
        {
            Beolvasas(); Console.WriteLine("\n--------------------------\n");
            Feladat2(); Console.WriteLine("\n--------------------------\n");
            Feladat3(); Console.WriteLine("\n--------------------------\n");
            Feladat4(); Console.WriteLine("\n--------------------------\n");
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.feladat: 8 éves vagy idősebb...:");
            DateTime Most = DateTime.Now;
            DateTime Szuletes;
            foreach (var c in Chi_List)
            {
                double Napok = (Most - c.Szul_Datum).TotalDays;
                int Evek = (int)Napok / 365;
                //Console.WriteLine($"{c.Nev, -15} : {Evek}");
                if (8 < Evek && c.Suly < 360)
                { Console.WriteLine($"{c.Nev}: {Evek} éves és {c.Suly} gramm."); }
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.feladat: Százalék számítás:");
            int SimiSzeret = 0;
            foreach (var c in Chi_List)
            {
                if (c.Simi == "I") 
                { SimiSzeret++; }
            }
            double Arany = SimiSzeret * 100 / Chi_List.Count;
            Console.WriteLine($"Ilyen arányban szeretik a simogatást: {Arany:0.00}%");
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.feladat: Összes Chinchilla:");
            Console.WriteLine($"{Chi_List.Count} Chinchilla adatait olvastuk be");
        }

        private static void Beolvasas()
        {
            Console.WriteLine("Beolvasás:");
            var sr = new StreamReader(@"chi.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Chi_List.Add(new Chi(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
using System.IO;
using System.Text;
namespace HelloWorld
{
    struct Chi
    {
        public string Nev;
        public string Szul_Datum;
        public int Suly;
        public string Simi;

        public Chi(string sor)
        {
            var dbok = sor.Split(";");
            this.Nev = dbok[0];
            this.Szul_Datum = dbok[1];
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
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.feladat: Összes Chinchilla");
            Console.WriteLine($"{Chi_List.Count} Chinchilla adatait olvastuk be");
        }

        private static void Beolvasas()
        {
            Console.WriteLine("Beolvasás");
            var sr = new StreamReader(@"chi.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                Chi_List.Add(new Chi(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
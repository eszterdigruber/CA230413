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
            
        }
    }
}
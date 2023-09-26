using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyTibor_BejegyzesProjekt
{
    class Program
    {
        static List<Bejegyzes> bejegyzesek = new List<Bejegyzes>();
        static void Main(string[] args)
        {
            
            Bejegyzes B1 = new Bejegyzes("Konstruktor József", "Gazdag lettem!");
            Bejegyzes B2 = new Bejegyzes("Paraméter Gáspár", "Szegény lettem!");
            bejegyzesek.Add(B1);
            bejegyzesek.Add(B2);
        }
        static void BejegyzesIras()
        {
            int db = 0;
            Console.WriteLine("Adjon meg egy természetes számot!");
            db = Convert.ToInt32(Console.ReadLine());
            if (db < 0)
            {
                Console.WriteLine("Természetes számot adjon meg");
            }
            else
            {
                for (int i = 0; i < db; i++)
                {
                    Console.WriteLine("Adjon megy egy szerzőt");
                    string szerzo = Console.ReadLine();
                    Console.WriteLine("Adja meg a tartalmat");
                    string tartalom = Console.ReadLine();
                    Bejegyzes B1 = new Bejegyzes(szerzo, tartalom);
                    bejegyzesek.Add(B1);
                }
            }
        }
    }
}

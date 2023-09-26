using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyTibor_BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bejegyzes> bejegyzesek = new List<Bejegyzes>();
            Bejegyzes B1 = new Bejegyzes("Konstruktor József", "Gazdag lettem!");
            Bejegyzes B2 = new Bejegyzes("Paraméter Gáspár", "Szegény lettem!");
            bejegyzesek.Add(B1);
            bejegyzesek.Add(B2);
        }
    }
}

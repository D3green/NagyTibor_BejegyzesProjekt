using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

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
            BejegyzesIras();
            Beolvas();
            LikeOsztas();
            //az előző committal az F feladatrészt is megcsináltam hogy lássam hogy kiosztja-e a likeokat
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                Console.WriteLine(bejegyzesek[i]);
            }
            Modosit();
            Console.WriteLine(bejegyzesek[1]);
            Console.ReadKey();
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
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("bejegyzesek.csv");
            while(!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];
                Bejegyzes B1 = new Bejegyzes(szerzo, tartalom);
                bejegyzesek.Add(B1);
            }
        }
        static void LikeOsztas()
        {
            int likeok = (bejegyzesek.Count) * 20;
            Random r = new Random();
            int index = 0;
            for (int i = 0; i < likeok; i++)
            {
                index = r.Next(0, bejegyzesek.Count);
                bejegyzesek[index].Like();
            }
        }
        static void Modosit()
        {
            string szoveg = "";
            Console.WriteLine("Adjon meg egy szöveget!");
            szoveg = Convert.ToString(Console.ReadLine());
            bejegyzesek[1].Tartalom = szoveg;
           
        }
        static void Legnepszerubb()
        {
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                if (max > bejegyzesek[i].Likeok)
                {
                    max = bejegyzesek[i].Likeok;
                    index = i;
                }
            }
            Console.WriteLine("Legtöbb like egy bejegyzésen: " + bejegyzesek[index].Likeok);
        }
       
    }
}

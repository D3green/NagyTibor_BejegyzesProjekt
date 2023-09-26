using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagyTibor_BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
           this.letrejott = DateTime.Now; //Ez lemaradt még az első feladatból
        }

        public string Szerzo { get => szerzo;}
       
        public int Likeok { get => likeok; }
        public DateTime Letrejott { get => letrejott; }
        public string Tartalom
        {
            get => tartalom;
            set
            {
                tartalom = value;
                szerkesztve = DateTime.Now;
           
            }
        }

        public void Like()
        {
            this.likeok++;
        }
        public override string ToString()
        {
            return $"{this.szerzo} - {this.likeok} - {this.letrejott} \n Szerkesztve: {this.szerkesztve} \n {this.tartalom} \n\n" ;
        }

    }
}

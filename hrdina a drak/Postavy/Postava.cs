using System;
using System.Collections.Generic;
using System.Text;

namespace hrdina_a_drak.Postavy
{
    public abstract class Postava
    {
        public string Jmeno { get; set; }
        public int Zdravi { get; set; }
        public int MaxPoskozeni { get; set; }
        public int MaxObrana { get; set; }

        protected Random generovani = new Random();

        public Postava(string jmeno, int zdravi, int maxPoskozeni, int maxObrana)
        {
            this.Jmeno = jmeno;
            this.Zdravi = zdravi;
            this.MaxPoskozeni = maxPoskozeni;
            this.MaxObrana = maxObrana;
        }

        public virtual void Utok(Postava oponent)
        {
            int poskozeni = Convert.ToInt32(generovani.NextDouble() * MaxPoskozeni);
            int obrana = oponent.Obrana();
            poskozeni -= obrana;
            oponent.Zdravi -= poskozeni;

            Console.WriteLine($"Utok {Jmeno} v hodnotě: " + poskozeni);
            Console.WriteLine($"Oponentovi jménem {oponent.Jmeno} zbývá zdraví o hodnotě: " + oponent.Zdravi);
        }

        public virtual int Obrana()
        {
            int obrana = 0;
            //postava se brani, pokud dojde k vygenerovani 0,5 a výš
            //if (Math.Round(generovani.NextDouble()) == 1)
            if (generovani.NextDouble() <= 0.5)
            {
                obrana = generovani.Next(0, MaxObrana);
                Console.WriteLine($"Obrana postavy jménem {Jmeno} v hodnotě: " + obrana);
            }
            return obrana;
        }

        public bool JeZiva()
        {
            if (Zdravi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual Postava VyberOponenta(List<Postava> postavy)
        {
            Postava oponent = null;

            foreach(var postava in postavy)
            {
                if (this != postava && postava.JeZiva() && KontrolaVyberuOponenta(postava))
                {
                    oponent = postava;
                    break;
                }
            }

            return oponent;
        }

        protected abstract bool KontrolaVyberuOponenta(Postava oponent);

    }
}

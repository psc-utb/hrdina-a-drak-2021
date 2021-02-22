using System;
using System.Collections.Generic;
using System.Text;

namespace hrdina_a_drak.Postavy
{
    public class Hrdina : Postava
    {
        public Hrdina(string jmeno, int zdravi, int maxPoskozeni, int maxObrana) : base(jmeno, zdravi, maxPoskozeni, maxObrana)
        {

        }

        //v rodičovské třídě Postava: změna z private na protected, protože se budeme chtít dostat na generování i v odvozené třídě
        //protected Random generovani = new Random();

        //v rodičovské třídě Postava: změna v metodě útok -> reference je Postava a v text byl přepsán do neutrální formy
        /*public void Utok(Postava oponent)
        {
            int poskozeni = Convert.ToInt32(generovani.NextDouble() * MaxPoskozeni);
            int obrana = oponent.Obrana();
            poskozeni -= obrana;
            oponent.Zdravi -= poskozeni;

            Console.WriteLine($"Utok {Jmeno} v hodnotě: " + poskozeni);
            Console.WriteLine($"Oponentovi jménem {oponent.Jmeno} zbývá zdraví o hodnotě: " + oponent.Zdravi);
        }*/

        //v rodičovské třídě Postava: změna v metodě Obrana: jen změna vypisovaného textu
        //Console.WriteLine($"Obrana postavy jménem {Jmeno} v hodnotě: " + obrana);

    }
}

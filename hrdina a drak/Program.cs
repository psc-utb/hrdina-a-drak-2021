using hrdina_a_drak.Postavy;
using System;
using System.Collections.Generic;

namespace hrdina_a_drak
{
    class Program
    {
        static void Main(string[] args)
        {
            Hrdina hrdina = new Hrdina("Geralt", 200, 175, 50);
            Drak drak = new Drak("Alduin", 350, 100, 40);
            Drak drak2 = new Drak("Šmak", 450, 75, 25);
            Hrdina hrdina2 = new Hrdina("Dovakhin", 150, 75, 35);
            //Vlk vlk = new Vlk("Vlk", 50);


            List<Postava> postavy = new List<Postava>();
            postavy.Add(hrdina);
            postavy.Add(drak);
            postavy.Add(drak2);
            postavy.Add(hrdina2);


            for (int i = 0; PocetZivychHrdinu(postavy) > 0 && PocetZivychDraku(postavy) > 0; ++i)
            {
                Console.WriteLine("Kolo č. " + i);

                for (int j = 0; j < postavy.Count; ++j)
                {
                    Postava utocnik = postavy[j];
                    if (utocnik.JeZiva())
                    {
                        Postava oponent = utocnik.VyberOponenta(postavy);
                        if (oponent != null)
                            utocnik.Utok(oponent);
                        else
                            continue;

                        Console.WriteLine(Environment.NewLine + Environment.NewLine);
                    }
                }
            }

            if (PocetZivychHrdinu(postavy) > 0)
            {
                Console.WriteLine("hrdinové vyhráli");
            }
            else if (PocetZivychDraku(postavy) > 0)
            {
                Console.WriteLine("draci vyhráli");
            }
            /*else
            {
                Console.WriteLine("Nikdo nevyhrál");
            }*/

        }

        public static int PocetZivychHrdinu(List<Postava> postavy)
        {
            int pocetZivychHrdinu = 0;
            foreach (Postava postava in postavy)
            {
                if (postava is Hrdina && postava.JeZiva())
                {
                    ++pocetZivychHrdinu;
                }
            }
            return pocetZivychHrdinu;
        }

        public static int PocetZivychDraku(List<Postava> postavy)
        {
            int pocetZivychHrdinu = 0;
            foreach (Postava postava in postavy)
            {
                if (postava is Drak && postava.JeZiva())
                {
                    ++pocetZivychHrdinu;
                }
            }
            return pocetZivychHrdinu;
        }
    }
}

using hrdina_a_drak.Nahoda;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrdina_a_drak.Postavy
{
    public class Vlk
    {
        private Generator generovani = Generator.Instance;

        public Vlk(string jmeno, int maxPoskozeni)
        {
            throw new System.NotImplementedException();
        }

        public string Jmeno { get; set; }

        public int Zdravi
        {
            get;
            set;
        }

        public int MaxPoskozeni
        {
            get;
            set;
        }

        public int MaxObrana
        {
            get;
            set;
        }

        public Tym Tym
        {
            get;
            set;
        }

        public void Utok(Hrdina hrdina)
        {
            throw new System.NotImplementedException();
        }

        public int Obrana()
        {
            throw new System.NotImplementedException();
        }
    }
}
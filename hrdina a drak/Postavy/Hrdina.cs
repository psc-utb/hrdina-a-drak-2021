using hrdina_a_drak.Veci;
using System;
using System.Collections.Generic;
using System.Text;

namespace hrdina_a_drak.Postavy
{
    public class Hrdina : Postava
    {
        public Mec Mec { get; set; }
        public Stit Stit { get; set; }

        public Hrdina(string jmeno, int zdravi, int maxPoskozeni, int maxObrana, Mec mec, Stit stit = null) : base(jmeno, zdravi, maxPoskozeni, maxObrana)
        {
            this.Mec = mec;
            this.Stit = stit;
        }

        public Hrdina(int zdravi, int maxPoskozeni, int maxObrana) : base (String.Empty, zdravi, maxPoskozeni, maxObrana)
        {

        }

        public Hrdina(string jmeno, int zdravi, int maxPoskozeni, int maxObrana) : this(jmeno, zdravi, maxPoskozeni, maxObrana, null, null)
        {

        }

        public new void Utok(Postava oponent)
        {
            //přidání poškození meče je na vás, toto jen volá stejnou metodu z rodičovské třídy Postava
            base.Utok(oponent);
        }

        public new int Obrana()
        {
            //přidání obrany štítu je na vás, toto jen volá stejnou metodu z rodičovské třídy Postava
            return base.Obrana();
        }

    }
}

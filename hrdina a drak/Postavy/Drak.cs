using System;
using System.Collections.Generic;
using System.Text;

namespace hrdina_a_drak.Postavy
{
    public class Drak : Postava
    {
        public Drak(string jmeno, int zdravi, int maxPoskozeni, int maxObrana) : base(jmeno, zdravi, maxPoskozeni, maxObrana)
        {

        }

        protected override bool KontrolaVyberuOponenta(Postava oponent)
        {
            return oponent.GetType() != this.GetType();
        }
    }
}

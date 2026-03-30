using System;
using System.Collections.Generic;
using System.Text;

namespace Plodiny2
{   // *
    internal class Hovezi : Plodina
    {
        public int zbyvajiciZrani; // zrání

        public Hovezi(string puvod, int zrani) : base(puvod) {
            trvanlivost = 10;
            pocetBilkovin = 20;
            zbyvajiciZrani = zrani;
            barva = ConsoleColor.Cyan;
        }

        protected override void Upgrade()
        {
            pocetBilkovin = (int)(1.2 * pocetBilkovin);
            uroven++;
        }

        public override int Sklidit()
        {
            uroven = -1;

            if(zbyvajiciZrani > 0)
            {
                return int.MinValue;
            }
            return pocetBilkovin;
        }

        public override void Zestarni() {
            zbyvajiciZrani--;
            base.Zestarni();
        }

        public override string ToString()
        {
            if(Zije() && zbyvajiciZrani > 0)
                return base.ToString() + $"(nech zrát ještě {zbyvajiciZrani} dní)";
            return base.ToString();
        }
    }
}

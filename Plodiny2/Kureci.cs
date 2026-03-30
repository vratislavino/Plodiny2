using System;
using System.Collections.Generic;
using System.Text;

namespace Plodiny2
{
    internal class Kureci : Plodina
    {
        public Kureci(string puvod) : base(puvod)
        {
            trvanlivost = 5;
            pocetBilkovin = 11;
            barva = ConsoleColor.Yellow;
        }

        protected override void Upgrade()
        {
            uroven++;
            pocetBilkovin = (int)(1.15 * pocetBilkovin);
            
            if (random.Next(0,100) < 10) {
                uroven++;
                pocetBilkovin = (int)(1.15 * pocetBilkovin);
            }

            if(random.Next(0, 100) < 10) {
                uroven = -1;
            }
        }
    }
}

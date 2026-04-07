using System;
using System.Collections.Generic;
using System.Text;

namespace Plodiny2
{
    public class Plodina
    {
        public int uroven = 0;
        public int pocetBilkovin;
        public int trvanlivost;
        public string puvod;
        public ConsoleColor barva;

        public string Name;

        public static Random random = new Random();

        public Plodina(string puvod) {
            this.puvod = puvod;
            this.uroven = 1;
        }

        public bool Zije() { return uroven > 0; }

        public void Zalit() {
            if (uroven < 0)
                return;
            
            trvanlivost += 10;
            Upgrade();
        }

        public virtual int Sklidit() {
            uroven = -1;
            return pocetBilkovin;
        }

        protected virtual void Upgrade() {
        }

        public virtual void Zestarni() {

            if (uroven < 0)
                return;

            trvanlivost--;
            if(trvanlivost <= 0)
            {
                uroven = -1;
            }
        } 

        public override string ToString() {
            if (uroven == -1)
                return "---";
            return $"{uroven} - trv. {trvanlivost} d. - {puvod} ({pocetBilkovin})";
        }
    }
}

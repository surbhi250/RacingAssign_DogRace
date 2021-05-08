using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssign_DogRace
{
   public class Plyer
    {
        public String nme;
        public int dog;
        public int budget;
        public int blnce;

        //defult constructor of the system 
        public Plyer(string nm,int dg,int bud,int bln) {
            nme = nm;
            dog = dg;
            budget = bud;
            blnce = bln;
        }

        //set the budget of the system 
        public int setBlnce(int win) {
            if (win == dog)
            {
                return blnce + budget;
            }
            else {
                return blnce - budget;
            }
        }



    }
}

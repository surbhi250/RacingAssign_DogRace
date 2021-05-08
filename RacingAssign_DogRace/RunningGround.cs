using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssign_DogRace
{
   public class RunningGround
    {
        Random rd = new Random();
        public int jump;
        public int stp=800;
        //this code is used to genrete the number 
        public void step() {
            jump = rd.Next(1, 80);
        }
    }
}

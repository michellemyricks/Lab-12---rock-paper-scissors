using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12___rock_paper_scissors
{
    public class playerRandom : Player
    {
        public override Roshambo generateRoshambo()
        {
            //random number generator
            Random numGenerator = new Random();
            int selectdNum  = numGenerator.Next(1, 4);

            //match one of the # with the Roshambo values
            int randomNumberReturned = numGenerator.Next(1, 4);

            //return the value
            return (Roshambo)randomNumberReturned;
        }
    }
}

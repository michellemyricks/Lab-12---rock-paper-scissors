using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12___rock_paper_scissors
{
    public class playerRock : Player
    {
        public override Roshambo generateRoshambo()
        {
            return Roshambo.Rock;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12___rock_paper_scissors
{
    public abstract class Player
    {
        public Roshambo playerChoice = Roshambo.Paper;
        public string name = "";
        public abstract Roshambo generateRoshambo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants;
        public string name;

        Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        //public string PickWinner()
        //{
        //    return winner;
        //}

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayContestantInfo(contestant);
        }
    }
}

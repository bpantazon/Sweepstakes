using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {


        Sweepstakes(string name)
        {

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

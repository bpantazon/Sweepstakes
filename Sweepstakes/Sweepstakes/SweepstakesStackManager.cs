using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            //for each to find the Sweepstakes you're looking for
            //grab an instantiated Sweepstakes object, pop from stack
            Sweepstakes chosenSweepstakes;
            chosenSweepstakes = sweepstakesStack.Pop();

            return chosenSweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
    }
}

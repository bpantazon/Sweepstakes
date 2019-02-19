using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            //for each to find the Sweepstakes you're looking for
            //grab an instantiated Sweepstakes object, dequeue from queue
            Sweepstakes chosenSweepstakes;
            chosenSweepstakes = queue.Dequeue();

            return chosenSweepstakes;          
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {            
            queue.Enqueue(sweepstakes);
        }
    }
}

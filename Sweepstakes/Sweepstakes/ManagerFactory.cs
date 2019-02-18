using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ManagerFactory
    {
       public void AssignSweepstakesType(string managerChoice)
        {
            //how to get the stack or queue to sweepstakes and each manager??? 
            if (managerChoice == "q")
            {
                SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
            }
            else if (managerChoice == "s")
            {
                SweepstakesStackManager stackManager = new SweepstakesStackManager();
            }
        }

    }
}

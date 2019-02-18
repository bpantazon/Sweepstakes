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
            
            switch (managerChoice)
            {
                case "q":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    break;
                case "s":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    break;
            }
            
        }

    }
}

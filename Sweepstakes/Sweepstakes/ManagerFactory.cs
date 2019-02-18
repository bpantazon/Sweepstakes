using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ManagerFactory
    {
       public ISweepstakesManager AssignSweepstakesType(string managerChoice)
        {
            //how to get the stack or queue to sweepstakes and each manager??? 
            //make method return something
            switch (managerChoice)
            {
                case "q":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    return queueManager;
                case "s":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    return stackManager;
                default:
                    return AssignSweepstakesType(managerChoice);
            }
            
        }

    }
}

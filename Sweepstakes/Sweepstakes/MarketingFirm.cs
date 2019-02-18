using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        List<ISweepstakesManager> managerList;
        ISweepstakesManager manager;
        ManagerFactory factory = new ManagerFactory();
        public MarketingFirm(ISweepstakesManager manager)
        {
            managerList = new List<ISweepstakesManager>();
            this.manager = manager;
        }
        public void runSweepstakes()
        {
            string managerChoice;
            managerChoice = UserInterface.ChooseManager();
            UserInterface.NameSweepstakes();
            
            factory.AssignSweepstakesType(managerChoice);




        }
        

    }
}

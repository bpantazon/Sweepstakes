using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string manager = UserInterface.ChooseManager(); //variable to store input of manager type
            ManagerFactory factory = new ManagerFactory(); //creates manager factory
            ISweepstakesManager madeManager = factory.AssignSweepstakesType(manager);  //variable of ISweepstakesManager to hold the created manager type         
            MarketingFirm marketingFirm = new MarketingFirm(madeManager); // creates MarketingFirm with the selected manager type of stack or queue 


            
            
        }
    }
}

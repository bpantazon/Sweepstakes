﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {

        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void runSweepstakes()
        {
            UserInterface.ChooseManager();
            UserInterface.NameSweepstakes();
            UserInterface.NameSweepstakes();
        }
        

    }
}

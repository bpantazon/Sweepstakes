using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;        
        public int registrationNumber;

        public Contestant(string firstName, string lastName, string email, int registrationNumber)
        {
            
            this.firstName = UserInterface.GetContestantInfo("firstname");
            this.lastName = UserInterface.GetContestantInfo("lastname");
            this.email = UserInterface.GetContestantInfo("email");    
            this.registrationNumber = registrationNumber;
        }
    }
}

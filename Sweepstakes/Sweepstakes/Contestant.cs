using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant /*: IObserver<email>*/
    {
        public string firstName;
        public string lastName;
        public string email;        
        public int registrationNumber;
        public bool isWinner = false;

        public Contestant(int registrationNumber, string firstName, string lastName, string email, bool isWinner)
        {
            this.firstName = UserInterface.GetContestantInfo("firstname");
            this.lastName = UserInterface.GetContestantInfo("lastname");
            this.email = UserInterface.GetContestantInfo("email");
            this.registrationNumber = registrationNumber;
            this.isWinner = isWinner;
        }
        public void Notify()
        {
            //send email
        }
    }
}

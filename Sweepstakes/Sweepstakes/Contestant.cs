using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        string firstName;
        string lastName;
        string email;
        string address;
        int registrationNumber;

        public Contestant(string firstName, string lastName, string email, string address, int registrationNumber)
        {
            //maybe make these null to start? similar to binary search tree?
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.address = address;
            this.registrationNumber = registrationNumber;
        }
    }
}

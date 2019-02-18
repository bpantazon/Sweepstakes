using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants;
        public string name;
        public Contestant winner;

        Sweepstakes(string name)
        {
            this.name = UserInterface.NameSweepstakes();
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public string PickWinner()
        {
            Random rand = new Random();
            int pickedRegistrationNumber;
            pickedRegistrationNumber = rand.Next(0, contestants.Count);
            winner = contestants[pickedRegistrationNumber];
            winner.isWinner = true;
            string winnerName = contestants[pickedRegistrationNumber].firstName + contestants[pickedRegistrationNumber].lastName + contestants[pickedRegistrationNumber].email;
            return winnerName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First name: {contestant.firstName}");
            Console.WriteLine($"Last name: {contestant.lastName}");
            Console.WriteLine($"Email: {contestant.email}");
            Console.ReadLine();
        }
        public void DecideToPickWinner(int response)
        {
            if (response == 1)
            {
                PickWinner();
            }           
        }

    }
}

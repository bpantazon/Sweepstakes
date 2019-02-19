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
            pickedRegistrationNumber = rand.Next(1, contestants.Count);
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
        public void NotifyContestants() //wrote to console in place of sending an email. Looking to change if MailKit API is implemented
        {
            for (int i = 0; i <= contestants.Count; i++)
            {
                if (contestants[i].isWinner == false)
                {                   
                    Console.WriteLine("Thank you for entering our sweepstakes! You didn't win.");
                }
                else if (contestants[i].isWinner == true)
                {
                    Console.WriteLine("You win! You will shortly receive an email with details.");
                }
            }
        }

    }
}

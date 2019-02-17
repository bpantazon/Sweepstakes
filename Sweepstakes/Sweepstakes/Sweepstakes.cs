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

        Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);
        }

        //public string PickWinner()
        //{
        //    return winner;
        //}

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First name: {contestant.firstName}");
            Console.WriteLine($"Last name: {contestant.lastName}");
            Console.WriteLine($"Email: {contestant.email}");
            Console.ReadLine();
        }
    }
}

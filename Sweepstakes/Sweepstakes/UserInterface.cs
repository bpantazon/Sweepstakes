using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string ChooseManager()
        {
            string managerChoice;
            Console.WriteLine("Do you want your sweepstakes managed via stack or queue? Type 's' for stack or 'q' for queue");
            managerChoice = Console.ReadLine().ToLower().Trim();
            if (managerChoice != "s" || managerChoice != "q")
            {
                Console.WriteLine("Please enter 's' or 'q'!");
                Console.ReadLine();
                ChooseManager();
            }
            return managerChoice;
        }

        public static string NameSweepstakes()
        {
            string sweepstakesName;
            Console.WriteLine("What is the name of this sweeepstakes?");
            sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }
     
       
        public static string GetContestantInfo(string info)
        {
            //int registration;
            switch (info)
            {
                default:
                    return "error";
                case "firstname":
                    Console.WriteLine("Please enter the first name: ");
                    return Console.ReadLine();
                case "lastname":
                    Console.WriteLine("Please enter the last name: ");
                    return Console.ReadLine();
                case "email":
                    Console.WriteLine("Please enter the email: ");
                    return Console.ReadLine();
                    //case "registrationNumber":
                    //    Console.WriteLine("Pleaes enter the registration number: ");
                    //    registration = Convert.ToInt32(Console.ReadLine());
                    //    return registration;

            }


        }
        public static int AskToRunSweepstakes()
        {
            int response = 0;
            Console.WriteLine("Are you ready to run sweepstakes? Type '1' to run sweepstakes or '2' to continue adding contestants");
            try
            {
                response = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a number of '1' or '2'!");
                AskToRunSweepstakes();
            }
            return response;
        }
    }
}

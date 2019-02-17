using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //similar to lemonade stand?

        public static void DisplayContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant: {contestant}");
            Console.WriteLine();
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
        public static string ChooseManager()
        {
            string managerChoice;
            Console.WriteLine("Do you want your sweepstakes managed via stack or queue? Type 's' for stack or 'q' for queue");
            managerChoice = Console.ReadLine();
            if (managerChoice != "s" || managerChoice != "q") 
            {
                Console.WriteLine("Please enter 's' or 'q'!");
                Console.ReadLine();
                ChooseManager();
            }
            return managerChoice;
        }
    }
}

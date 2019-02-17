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
                case "address":
                    Console.WriteLine("Please enter the street address: ");
                    return Console.ReadLine();
                case "email":
                    Console.WriteLine("Please enter the email: ");
                    return Console.ReadLine();
                case "registrationNumber":
                    Console.WriteLine("Pleaes enter the registration number: ");
                    return Console.ReadLine();

            }
            
        }
    }
}

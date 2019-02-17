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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much gold you have");
            double GoldBalance = double.Parse(Console.ReadLine());
            Console.WriteLine(GoldBalance);

            if (GoldBalance < 400) 
            {
                Console.WriteLine ("you have enough for a friend too! you may go into the aerosmith concert");
            }
            else if (GoldBalance < 200)
            {
                Console.WriteLine("you may go into the aerosmith concert");
            }
            else
            {
                Console.WriteLine("TOO BAD GO MAKE SOME GOLD");

            Console.ReadKey();
            }
        }
    }
}

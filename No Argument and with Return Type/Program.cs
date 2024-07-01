using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace No_Argument_and_with_Return_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Call the GetRandomNumber function and print the result
                int number = GetRandomNumber();
                Console.WriteLine($"Random number: {number}");
                Console.ReadKey();
            }

            // Function with no arguments and with return type
            
            int  GetRandomNumber()
            {
                Random random = new Random();// instance of the Random class.

                return random.Next(1, 101); // Returns a random number between 1 and 100
            }
        }
    }
}

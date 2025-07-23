using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN
{
    internal class gender
    {
        static void Main()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Char.ToUpper(Console.ReadKey().KeyChar); // Read single char
            Console.WriteLine(); // To move to the next line after gender input

            if (gender == 'M')
            {
                Console.WriteLine("Output: Mr. " + name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Output: Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender entered. Please enter M or F.");
            }
        }
    }
}

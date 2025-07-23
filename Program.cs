using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + new string('X', 5);
                Console.WriteLine("Masked Mobile Number: " + masked);
            }
            else
            {
                Console.WriteLine("Mobile number is too short to mask!");
            }
        }
    }
}

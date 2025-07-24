using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN
{
    internal class armstrong
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int originalNum = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit * digit; // Cube of digit
                num /= 10;
            }

            if (sum == originalNum)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not an Armstrong number");
        }
    }
}

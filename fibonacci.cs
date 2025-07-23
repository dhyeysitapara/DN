using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN
{
    internal class fibonacci
    {
        static void Main()
        {
            int n = 11; // Number of terms in the series
            int a = 0, b = 1;

            Console.Write("Fibonacci Series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
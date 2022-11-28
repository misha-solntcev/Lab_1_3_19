using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 19. Вычислите 1 * 2 + 2 * 3 * 4 +…+n * (n + 1) *…*2n */

namespace Lab_1_3_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int sum = 1 * 2;
            while (true)
            {
                n++;
                sum += n * (n + 1) * 2 * n;
                Console.WriteLine($"n={n}, n+1={n+1}, 2*n={2*n}");
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}

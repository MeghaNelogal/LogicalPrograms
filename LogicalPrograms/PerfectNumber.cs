using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int num = 28, sum = 0, n;
            n = num;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(n + " is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(n + " is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}

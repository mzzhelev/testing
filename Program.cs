using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            var totalSum = 0;
            var combinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if(sum > totalSum)
                    {
                        totalSum += (i * j) * 3;
                        combinations++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if(totalSum >= sum)
            {
                Console.WriteLine($"{combinations} combinations\nSum: {totalSum} >= {sum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations\nSum: {totalSum}");
            }
        }
    }
}

taq zada4a ne raboti
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigOfSumOfFibosAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Int64 num1 = Int64.Parse(input[0]);
            Int64 num2 = Int64.Parse(input[1]);
            int[] Iter = { 1, 1, 2, 3, 5, 8, 3, 1, 4, 5, 9, 4, 3, 7, 0, 7, 7, 4, 1, 5, 6, 1, 7, 8, 5, 3, 8, 1, 9, 0, 9, 9, 8, 7, 5, 2, 7, 9, 6, 5, 1, 6, 7, 3, 0, 3, 3, 6, 9, 5, 4, 9, 3, 2, 5, 7, 2, 9, 1, 0 };
            int Sum = 0;
            if (num1 != 0 && num2 != 0)
            {
                if (num1 / 60 == num2 / 60)
                    for (int i = (int)(num1 % 60) - 1; i < num2 % 60; i++)
                        Sum += Iter[i];
                else
                {
                    for (int i = (int)(num1 % 60 - 1); i < 60; i++)
                        Sum += Iter[i];
                    for (int j = 0; j < num2 % 60; j++)
                        Sum += Iter[j];
                }
                Console.WriteLine(Sum % 10);
            }
            else if (num1 == 0 && num2 == 0)
                Console.WriteLine(0);
            else
            {
                for (int i = 0; i <= num2 % 60 - 1; i++)
                    Sum += Iter[i];
                Console.WriteLine(Sum%10);
            }

        }
    }
}

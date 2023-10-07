using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);
            Int64 Mult = Convert.ToInt64(num1) * num2;
            while (num2 != 0)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp % num2;
            }

            Console.WriteLine(Mult/num1);
        }
    }
}

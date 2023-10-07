using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArrayCounter = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(numbers);
            Console.WriteLine(Convert.ToInt64(numbers[ArrayCounter - 1]) * numbers[ArrayCounter - 2]);
        }


    }
}

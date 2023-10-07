using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberOfPrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int InputNumber = int.Parse(Console.ReadLine());
            int CopyOfInput = InputNumber;
            List<int> Totaled = new List<int>();
            for (int i = 1; i <= CopyOfInput; i++)
            {
                if (InputNumber > (i * 2))
                {
                    InputNumber -= i;
                    Totaled.Add(i);
                }
                else
                {
                    Totaled.Add(InputNumber);
                    break;
                }
            }
            Console.WriteLine(Totaled.Count);
            Console.WriteLine(string.Join(" ", Totaled));
        }
    }
}

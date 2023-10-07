using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueOfLoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int Quantity = int.Parse(input[0]);
            int TotalWeight = int.Parse(input[1]);

            Tuple<int, int, double>[] Info = new Tuple<int, int, double>[Quantity];

            for (int i = 0; i < Quantity; i++)
            {
                string[] item = Console.ReadLine().Split();
                int value = int.Parse(item[0]);
                int weight = int.Parse(item[1]);
                Info[i] = new Tuple<int, int, double>(value, weight, (double)(value) / weight);
            }
            Array.Sort(Info, (x, y) => x.Item3.CompareTo(y.Item3));

            int Counter = Info.Length - 1;
            double TotalValue = 0;
            if (Quantity == 1)
            {
                if (TotalWeight >= Info[Counter].Item2)
                {
                    Console.WriteLine(Info[Counter].Item1);
                }
                else
                {
                    Console.WriteLine(Info[Counter].Item1 / (Info[Counter].Item2 / (double)TotalWeight));
                }
            }
            else
            {
                while (TotalWeight != 0)
                {
                    if (Info[Counter].Item2 <= TotalWeight)
                    {
                        TotalValue += Info[Counter].Item1;
                        TotalWeight -= Info[Counter].Item2;
                        Counter -= 1;
                    }
                    else
                    {
                        TotalValue += Info[Counter].Item1 / (Info[Counter].Item2 / (double)TotalWeight);
                        TotalWeight = 0;
                    }
                }
                Console.WriteLine(TotalValue);
            }
        }
    }
}

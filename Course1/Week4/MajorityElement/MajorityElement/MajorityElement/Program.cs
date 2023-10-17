using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ElementCounter = int.Parse(Console.ReadLine());
            string[] InputDigits = Console.ReadLine().Split();
            List<int> Elements = InputDigits.ToList().ConvertAll(int.Parse);
            Elements.Sort();
            Elements.Add(0);
            int count = 1;
            List<int> NumberCounter = new List<int>();
            if (Elements.Count == 1)
                Console.WriteLine(1);
            else if (Elements.Count == 2)
            {
                if (Elements[0] == Elements[1])
                    Console.WriteLine(1);
                else
                    Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < ElementCounter; i++)
                {
                    if (Elements[i] == Elements[i + 1])
                        count += 1;
                    else
                    {
                        NumberCounter.Add(count);
                        count = 1;
                    }
                }

                int Indexer = 0;
                foreach (var item in NumberCounter)
                {
                    if (item > (ElementCounter / 2))
                        Indexer += 1;
                }
                Console.WriteLine(Indexer);
            }
        }
    }
}

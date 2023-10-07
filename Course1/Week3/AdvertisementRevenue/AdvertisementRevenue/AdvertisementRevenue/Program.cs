using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementRevenue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = int.Parse(Console.ReadLine());
            string[] Prices = Console.ReadLine().Split();
            string[] Clicks = Console.ReadLine().Split();
            List<int> price = new List<int>();
            List<int> click = new List<int>();
            if (Counter != 0)
            {
                for (int i = 0; i < Counter; i++)
                {
                    price.Add(int.Parse(Prices[i]));
                    click.Add(int.Parse(Clicks[i]));
                }
                price.Sort();
                click.Sort();
                Int64 Total = 0;
                for (int i = 0; i < Counter; i++)
                {
                    Total += (Int64)(price[i]) * click[i];
                }
                Console.WriteLine(Total);
            }
            else
                Console.WriteLine();

        }
    }
}

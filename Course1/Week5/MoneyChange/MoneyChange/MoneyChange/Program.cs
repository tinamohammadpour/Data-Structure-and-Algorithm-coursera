using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Money = int.Parse(Console.ReadLine());
            List<int> MoneyChange = new List<int>();
            int min;
            MoneyChange.Add(0);
            MoneyChange.Add(1);
            MoneyChange.Add(2);
            MoneyChange.Add(1);
            MoneyChange.Add(1);
            if (Money >= 1 && Money <= 4)
                Console.WriteLine(MoneyChange[Money]);
            else
            {
                for (int i = 5; i <= Money; i++)
                {
                    min = Math.Min(MoneyChange[i - 1], Math.Min(MoneyChange[i - 3], MoneyChange[i - 4]));
                    MoneyChange.Add(min + 1);
                }
                Console.WriteLine(MoneyChange[MoneyChange.Count - 1]); 
            }

        }
    }
}

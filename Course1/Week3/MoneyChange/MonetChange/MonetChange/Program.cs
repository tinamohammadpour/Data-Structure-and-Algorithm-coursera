using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MoneyAmount = int.Parse(Console.ReadLine());
            Console.WriteLine(MoneyAmount / 10 + ((MoneyAmount % 10) / 5) + MoneyAmount % 5);
            
        }
    }
}

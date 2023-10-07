using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Fib = new int[n+1];
            Fib[0] = 0;
            if (n>=1)
                Fib[1]=1;
            if(n>=2)
            {
                for (int i = 2; i <= n; i++)
                    Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
            Console.WriteLine(Fib[n]);
        }
    }
}

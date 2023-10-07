using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32((Input.Split())[0]) + Convert.ToInt32((Input.Split())[1]));
        }
    }
}

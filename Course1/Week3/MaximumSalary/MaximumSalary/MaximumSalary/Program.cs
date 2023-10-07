using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSalary
{
    internal class Program
    {
        public static bool IsBigger(int num1, int num2) => int.Parse(num1.ToString() + num2.ToString()) > int.Parse(num2.ToString() + num1.ToString());
        static void Main(string[] args)
        {
            int DigitCounter = int.Parse(Console.ReadLine());
            string[] InputDigits = Console.ReadLine().Split();
            List<string> Digits = InputDigits.ToList();

           

            List<string> Salary = new List<string>();
            while (Digits.Count != 0)
            {
                int MaxNumber = 0;
                for (int i = 0; i < Digits.Count; i++)
                {
                    if (IsBigger(int.Parse(Digits[i]), MaxNumber))
                        MaxNumber = int.Parse(Digits[i]);
                }
                Digits.Remove(MaxNumber.ToString());
                Salary.Add(MaxNumber.ToString());

            }
            Console.WriteLine(string.Join("", Salary));
        }
    }
}

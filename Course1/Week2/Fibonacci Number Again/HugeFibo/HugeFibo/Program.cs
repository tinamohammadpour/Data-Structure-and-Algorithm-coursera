using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HugeFibo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Int64 num1 = Int64.Parse(input[0]);
            Int64 num2 = Int64.Parse(input[1]);

            List<int> Reminder = new List<int> { 0, 1 };
            int F1 = 0;
            int F2 = 1;

            if (num2 == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (true)
                {
                    int F3 = (int)((F1 + F2) % num2);
                    F1 = F2;
                    F2 = F3;
                    Reminder.Add(F3);
                    if (Reminder[Reminder.Count-1] == 0 && Reminder[Reminder.Count-2] == 1)
                    {
                        break;
                    }
                }

                Reminder.RemoveAt(Reminder.Count - 1);

                int Index = (int)(num1 % Reminder.Count);
                Console.WriteLine(Reminder[Index]);
            }
        }



    }
      
}

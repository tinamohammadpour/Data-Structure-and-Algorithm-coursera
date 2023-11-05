using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            int InputNumebr = int.Parse(Console.ReadLine());
            int min;
            List<int> Steps = new List<int>();
            List<int> Calculation = new List<int>();
            Calculation.Add(0);
            Calculation.Add(0);
            if (InputNumebr == 1)
                Console.WriteLine(Calculation[1]);
            else
            {
                for (int i = 2; i <= InputNumebr; i++)
                {
                    int Num2 = int.MaxValue;
                    int Num3 = int.MaxValue;
                    int Num1;
                    if (i % 2 == 0)
                        Num2 = Calculation[i / 2];
                    if (i % 3 == 0)
                        Num3 = Calculation[i / 3];
                    Num1 = Calculation[i - 1];
                    min = Math.Min(Num1, Math.Min(Num2, Num3));
 
                    Calculation.Add(min + 1);
                    

                }

                Console.WriteLine(Calculation[InputNumebr] );
                int Copy = InputNumebr;
                while(InputNumebr!=1)
                {
                    if (InputNumebr % 3 == 0 && Calculation[InputNumebr] == Calculation[InputNumebr/3]+1)
                    {
                        InputNumebr = InputNumebr / 3;
                        Steps.Add(InputNumebr);
                    }
                    if (InputNumebr % 2== 0 && Calculation[InputNumebr] == Calculation[InputNumebr / 2]+1)
                    {
                        InputNumebr = InputNumebr / 2;
                        Steps.Add(InputNumebr);
                    }

                    if (Calculation[InputNumebr] == Calculation[InputNumebr -1]+1)
                    {
                        InputNumebr = InputNumebr - 1;
                        Steps.Add(InputNumebr);
                    }
                    
                    
                }
                Steps.Reverse();
                Steps.Add(Copy);
                Console.WriteLine(string.Join(" ", Steps));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditDistance
{
    internal class Program
    {
        static int EditDistance(string str1, string str2)
        {
            int[,] Matrix = new int[str1.Length + 1, str2.Length + 1];

            for (int i = 0; i <= str1.Length; i++)
            {
                Matrix[i, 0] = i;
            }

            for (int i = 0; i <= str2.Length; i++)
            {
                Matrix[0, i] = i;
            }

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    int insertion = Matrix[i, j - 1] + 1;
                    int deletion = Matrix[i - 1, j] + 1;
                    int match = Matrix[i - 1, j - 1];
                    int mismatch = Matrix[i - 1, j - 1] + 1;

                    if (str1[i - 1] == str2[j - 1])
                    {
                        Matrix[i, j] = Math.Min(Math.Min(match, insertion), deletion);
                    }
                    else
                    {
                        Matrix[i, j] = Math.Min(Math.Min(mismatch, insertion), deletion);
                    }
                }
            }

            return Matrix[str1.Length, str2.Length];
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(EditDistance(str1, str2));
        }
    }
}

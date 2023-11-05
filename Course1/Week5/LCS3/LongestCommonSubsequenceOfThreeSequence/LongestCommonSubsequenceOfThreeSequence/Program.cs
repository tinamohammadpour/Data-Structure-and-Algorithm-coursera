using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequenceOfThreeSequence
{
    internal class Program
    {
        static int LongestSub(string[] str1, string[] str2, string[] str3)
        {
            int[,,] Matrice = new int[str1.Length + 1, str2.Length + 1,str3.Length+1];

            for (int i = 0; i <= str1.Length; i++)
                Matrice[i, 0,0] = 0;
           
            for (int i = 1; i <= str2.Length; i++)
                Matrice[0, i,0] = 0;

            for (int i = 1; i <= str3.Length; i++)
                Matrice[0, 0,i] = 0;

            for (int i = 1; i <= str1.Length; i += 1)
            {
                for (int j = 1; j <= str2.Length; j += 1)
                {
                    for (int k = 1; k <= str3.Length; k++)
                    {
                        if (str1[i - 1] == str2[j - 1] && str2[j-1] ==str3[k-1])
                            Matrice[i, j,k] = Matrice[i - 1, j - 1,k-1] + 1;
                        else
                            Matrice[i, j,k] = Math.Max(Math.Max(Matrice[i, j - 1,k], Matrice[i - 1, j, k]), Matrice[i, j, k - 1]);
                    }
                }
            }
            return Matrice[str1.Length, str2.Length,str3.Length];
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] Input1 = Console.ReadLine().Split();


            Console.ReadLine();
            string[] Input2 = Console.ReadLine().Split();

            Console.ReadLine();
            string[] Input3 = Console.ReadLine().Split();

            Console.WriteLine(LongestSub(Input1, Input2,Input3));
        }
    }
}

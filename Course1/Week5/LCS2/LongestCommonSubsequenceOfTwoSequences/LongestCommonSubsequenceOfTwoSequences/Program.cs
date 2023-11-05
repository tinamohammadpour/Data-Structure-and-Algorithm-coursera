using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LongestCommonSubsequenceOfTwoSequences
{
    internal class Program
    {
        static int LongestSub(string[] str1,string[] str2)
        {
            int[,] Matrice = new int[str1.Length + 1, str2.Length + 1];
            
            for(int i=0;i<=str1.Length;i++)
            {
                Matrice[i, 0] = 0;
            }
                
            for (int i = 1; i <= str2.Length; i++)
                Matrice[0, i] = 0;

            for (int i = 1; i <= str1.Length; i+=1)
            {
                for (int j = 1; j <= str2.Length; j+=1)
                {
                    if (str1[i - 1] == str2[j - 1])
                        Matrice[i, j] = Matrice[i - 1, j - 1] + 1;
                    if (str1[i - 1] != str2[j - 1])
                        Matrice[i, j] = Math.Max(Matrice[i, j - 1], Matrice[i - 1, j]);

                }
            }
            return Matrice[str1.Length, str2.Length];
        }
        static void Main(string[] args)
        {

            Console.ReadLine();
            string[] Input1= Console.ReadLine().Split();
           

            Console.ReadLine();
            string[] Input2= Console.ReadLine().Split();
           
            Console.WriteLine(LongestSub(Input1, Input2));
        }
    }
}

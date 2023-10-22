using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static int L1;
        static int L2;
        static List<int> RandomizedQuickSort(List<int> Arr,int LeftIndex,int RightIndex)
        {
            if (LeftIndex >= RightIndex) return Arr;

            Random random = new Random();
            int RandIndex = random.Next(LeftIndex, RightIndex);
            int RandDigit = Arr[RandIndex];
            Swap(Arr, LeftIndex, RightIndex);
            Partition(Arr, LeftIndex, RightIndex);
            RandomizedQuickSort(Arr, LeftIndex, L1-1);
            RandomizedQuickSort(Arr, L2 + 1, RightIndex);
                     
            return Arr;
        }

        static void Swap(List<int> sw,int i,int j)
        {
            int tmp = sw[i];
            sw[i] = sw[j];
            sw[j] = tmp;
        }

        static List<int> Partition(List<int> Par,int Left,int Right)
        {
            L1 = Left;
            int L1Value = Par[Left];
            for (int i = Left + 1; i <= Right;i++)
            {
                if (Par[i] < L1Value)
                { 
                    L1++;
                    Swap(Par, i, L1);
                }
            }
            Swap(Par, Left, L1);
            L2 = L1;
            int L2Value = Par[L1];
            for(int i=L1+1;i<=Right;i++)
            {
                if (Par[i]==L2Value)
                {
                    L2++;
                    Swap(Par, i, L2);
                }
            }
            Swap(Par, L1, L2);
            return Par;
        }
        static void Main(string[] args)
        {
            int ElementCounter = int.Parse(Console.ReadLine());
            string[] InputDigits = Console.ReadLine().Split();
            List<string> Digs = InputDigits.ToList();
            List<int> Elements = Digs.Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", RandomizedQuickSort(Elements,0,ElementCounter-1)));
        }
    }
}

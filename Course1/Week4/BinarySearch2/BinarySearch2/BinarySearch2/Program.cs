using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch2
{
    internal class Program
    {
        static int binarysearch(int[] SortedArr, int key)
        {
            int left = 0;
            int right = SortedArr.Length - 1;
            while (left <= right)
            {
                int Mid = (left + right) / 2;
                if (SortedArr[Mid] == key && Mid!=0&& SortedArr[Mid - 1] != key)
                    return Mid;
                else if (SortedArr[Mid] == key && Mid!=0&& SortedArr[Mid - 1] == key )
                    right = Mid - 1;
                else if (SortedArr[Mid] < key)
                    left = Mid + 1;
                else
                    right = Mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int ArrayCounter = int.Parse(Console.ReadLine());
            string[] SortedArray = Console.ReadLine().Split();
            int[] MySortedInt = new int[ArrayCounter];
            MySortedInt = Array.ConvertAll<string, int>(SortedArray, int.Parse);
            int KeyCounter = int.Parse(Console.ReadLine());

            string[] Keys = Console.ReadLine().Split();
            int[] KeyArray = new int[ArrayCounter];
            KeyArray = Array.ConvertAll<string, int>(Keys, int.Parse);
            List<int> Result = new List<int>();
            for (int i = 0; i < Keys.Length; i++)
            {
                if (KeyArray[i] == MySortedInt[0])
                    Result.Add(0);
                else
                    Result.Add(binarysearch(MySortedInt, KeyArray[i]));
            }
                
            Console.WriteLine(string.Join(" ", Result));
        }

    }
}

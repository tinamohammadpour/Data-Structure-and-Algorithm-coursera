using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversions
{

    internal class Program
    {
        static int SwapCounter = 0;
        static int[] Merge(int[] LeftArr, int[] RightArr)
        {
            
            int[] Merged = new int[LeftArr.Length + RightArr.Length];
            int Left = 0;
            int Right = 0;
            int Result = 0;

            while (Left < LeftArr.Length || Right < RightArr.Length)
            {
                if (Left < LeftArr.Length && Right < RightArr.Length)
                {
                    if (LeftArr[Left] <= RightArr[Right])
                    {
                        Merged[Result] = LeftArr[Left];
                        Left++;
                        Result++;
                    }
                    else
                    {
                        Merged[Result] = RightArr[Right];
                        Right++;
                        Result++;
                        SwapCounter+=LeftArr.Length-Left;
                    }
                }
                else if (Left < LeftArr.Length)
                {
                    Merged[Result] = LeftArr[Left];
                    Left++;
                    Result++;
                }
                else if (Right < RightArr.Length)
                {
                    Merged[Result] = RightArr[Right];
                    Right++;
                    Result++;
                    
                }
            }
            return Merged;
        }

        static int[] MergeSort(int[] Arr)
        {
            int[] Left;
            int[] Right;
            int[] Result = new int[Arr.Length];
            if (Arr.Length <= 1)
                return Arr;
            int Middle = Arr.Length / 2;
            Left = new int[Middle];
            if (Arr.Length % 2 == 0)
                Right = new int[Middle];
            else
                Right = new int[Middle + 1];
            for (int i = 0; i < Middle; i++)
                Left[i] = Arr[i];
            for (int j = Middle; j < Arr.Length; j++)
                Right[j - Middle] = Arr[j];
            Left = MergeSort(Left);
            Right = MergeSort(Right);
            Result = Merge(Left, Right);
            return Result;
        }
        static void Main(string[] args)
        {
            int ElementCounter = int.Parse(Console.ReadLine());
            string[] InputDigits = Console.ReadLine().Split();
            int[] Elements = new int[ElementCounter];
            Elements = Array.ConvertAll(InputDigits, int.Parse);
            MergeSort(Elements);
            Console.WriteLine(SwapCounter);

        }
    }
}
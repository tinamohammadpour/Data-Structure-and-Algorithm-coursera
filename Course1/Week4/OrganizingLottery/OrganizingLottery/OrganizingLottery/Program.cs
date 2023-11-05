using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizingLottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string>> tuples = new List<Tuple<int, string>>();
            string[] input1 = Console.ReadLine().Split();
            int s = int.Parse(input1[0]);
            int p = int.Parse(input1[1]);

            for (int i = 0; i < s; i++)
            {
                string[] input2 = Console.ReadLine().Split();
                tuples.Add(new Tuple<int, string>(int.Parse(input2[0]), "Left"));
                tuples.Add(new Tuple<int, string>(int.Parse(input2[1]), "Right"));
            }

            string[] points = Console.ReadLine().Split();
            foreach (string point in points)
            {
                tuples.Add(new Tuple<int, string>(int.Parse(point), "Point"));
            }

            tuples.Sort();

            int segmentCount = 0;
            Dictionary<int, int> pointSegmentMap = new Dictionary<int, int>();

            foreach (var tuple in tuples)
            {
                if (tuple.Item2 == "Left")
                {
                    segmentCount++;
                }
                else if (tuple.Item2 == "Right")
                {
                    segmentCount--;
                }
                else
                {
                    pointSegmentMap[tuple.Item1] = segmentCount;
                }
            }

            List<int> PointIter=new List<int>();
            foreach (string point in points)
            {
                PointIter.Add(pointSegmentMap[int.Parse(point)]);
            }
            Console.WriteLine(string.Join(" ", PointIter));
        }
    }
}

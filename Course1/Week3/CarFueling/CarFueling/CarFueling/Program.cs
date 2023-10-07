using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFueling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalDistance = int.Parse(Console.ReadLine());
            int MileOnFullTank = int.Parse(Console.ReadLine());
            int StopCounter = int.Parse(Console.ReadLine());
            string[] Stations = Console.ReadLine().Split();
            List<int> Stops = new List<int>();
            Stops.Add(0);
            for (int i = 0; i < Stations.Length; i++)
                Stops.Add(int.Parse(Stations[i]));
            Stops.Add(TotalDistance);
            bool fail = false;
            int Miles = 0;
            int NumberOfRefill = 0;
            for(int i=1;i<Stops.Count;i++)
            {
                if (Stops[i] - Stops[i-1]>MileOnFullTank)
                {
                    Console.WriteLine(-1);
                    fail = true;
                    break;
                }
            }
            if (fail == false)
            {
                List<int> MileInfo = new List<int>();
                for (int i = 1; i < Stops.Count; i++)
                {
                    Miles += Stops[i] - Stops[i - 1];
                    MileInfo.Add(Miles);
                    if (Miles > MileOnFullTank)
                    {
                        NumberOfRefill += 1;
                        Miles = Stops[i] - Stops[i - 1];
                    }
                    if (Miles == MileOnFullTank)
                    {
                        NumberOfRefill += 1;
                        Miles = 0;
                    }

                }
                if (Stops[Stops.Count - 1] == Stops[Stops.Count-2])
                {
                    if (MileInfo[MileInfo.Count - 2] == MileOnFullTank)
                        NumberOfRefill -= 1;
                }
                else
                {
                    if (MileInfo[MileInfo.Count - 1] == MileOnFullTank)
                        NumberOfRefill -= 1;
                }
                Console.WriteLine(NumberOfRefill);


            }

        }
    }
}

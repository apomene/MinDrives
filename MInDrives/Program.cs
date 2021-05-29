using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInDrives
{
    class Program
    {
        static void Main(string[] args)
        {
            DiskSpace diskSPace = new DiskSpace();
            var used = new int[] { 300, 525, 110 };
            var totals = new int[] { 350, 600, 115 };

            var used2 = new int[] { 1, 200, 200, 199, 200, 200 };
            var totals2 = new int[] { 1000, 200, 200, 200, 200, 200 };

            var used3 = new int[] { 750, 800, 850, 900, 950 };
            var totals3 = new int[] { 800, 850, 900, 950, 1000 };

            var used4 = new int[]{49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,
                                  49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,
                                  49,49,49,49,49,49,49,49,49,49,49,49};
            var totals4 = new int[]{50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,
                                    50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,
                                    50,50,50,50,50,50,50,50,50,50,50,50};
            var used5 = new int[] { 331, 242, 384, 366, 428, 114, 145, 89, 381, 170, 329, 190, 482, 246, 2, 38, 220, 290, 402, 385 };
            var totals5 = new int[] { 992, 509, 997, 946, 976, 873, 771, 565, 693, 714, 755, 878, 897, 789, 969, 727, 765, 521, 961, 906 };

            Console.WriteLine(diskSPace.MinDrives(used5, totals5));
            Console.ReadLine();


        }
    }
    
}

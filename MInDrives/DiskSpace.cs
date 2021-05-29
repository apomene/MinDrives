using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MInDrives
{
    public class DiskSpace
    {
        public int MinDrives(int[] used,int[] total)
        {
            //first we sort total array descending
            var sortedTotals = total.ToList().OrderByDescending(x => x);
            //we calclate the sum of used
            var UsedSum = used.ToList().Sum();
            var finalSum = 0;
            var result = 0;
            foreach (var sortedTotal in sortedTotals)
            {
                finalSum += sortedTotal;
                result++;
                if (finalSum >= UsedSum)
                {
                    return result;
                }
            }
            return result;
        }
    }
}

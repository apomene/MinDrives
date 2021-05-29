using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MInDrives;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        DiskSpace diskSPace = new DiskSpace();
        [TestMethod]
        public void TestMethod1()
        {
           
            var used = new int[] { 300, 525, 110 };
            var totals = new int[] { 350, 600, 115 };

            Assert.IsTrue(diskSPace.MinDrives(used, totals) == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var used2 = new int[] { 1, 200, 200, 199, 200, 200 };
            var totals2 = new int[] { 1000, 200, 200, 200, 200, 200 };

            Assert.IsTrue(diskSPace.MinDrives(used2, totals2) == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var used3 = new int[] { 750, 800, 850, 900, 950 };
            var totals3 = new int[] { 800, 850, 900, 950, 1000 };

            Assert.IsTrue(diskSPace.MinDrives(used3, totals3) == 5);
        }


        [TestMethod]
        public void TestMethod4()
        {
            var used4 = new int[]{49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,
                                  49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,
                                  49,49,49,49,49,49,49,49,49,49,49,49};
            var totals4 = new int[]{50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,
                                    50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,
                                    50,50,50,50,50,50,50,50,50,50,50,50};

            Assert.IsTrue(diskSPace.MinDrives(used4, totals4) == 49);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var used5 = new int[] { 331, 242, 384, 366, 428, 114, 145, 89, 381, 170, 329, 190, 482, 246, 2, 38, 220, 290, 402, 385 };
            var totals5 = new int[] { 992, 509, 997, 946, 976, 873, 771, 565, 693, 714, 755, 878, 897, 789, 969, 727, 765, 521, 961, 906 };


            Assert.IsTrue(diskSPace.MinDrives(used5, totals5) == 6);
        }
    }
}

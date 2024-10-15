using Tyuiu.RyabtsevNE.Sprint2.Task5.V1.Lib;

namespace Tyuiu.RyabtsevNE.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindMonthDaysCount()
        {
            DataService ds = new DataService();

            StringAssert.Equals("??????", ds.FindMonthDaysCount(1));
            StringAssert.Equals("???????", ds.FindMonthDaysCount(2));
            StringAssert.Equals("????   ", ds.FindMonthDaysCount(3));
            StringAssert.Equals("??????", ds.FindMonthDaysCount(4));
            StringAssert.Equals("???", ds.FindMonthDaysCount(5));
            StringAssert.Equals("????", ds.FindMonthDaysCount(6));
            StringAssert.Equals("????", ds.FindMonthDaysCount(7));
            StringAssert.Equals("??????", ds.FindMonthDaysCount(8));
            StringAssert.Equals("????????", ds.FindMonthDaysCount(9));
            StringAssert.Equals("???????", ds.FindMonthDaysCount(10));
            StringAssert.Equals("??????", ds.FindMonthDaysCount(11));
            StringAssert.Equals("???????", ds.FindMonthDaysCount(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(13);
            });

        }
    }
}
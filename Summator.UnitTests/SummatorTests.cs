using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers() 
        {
            int[] nums = new int[] { 1, 2 };
            long actual = Summator.Sum(nums);
            
            long expected = 3;

            Assert.AreEqual(expected, actual);  
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            int[] nums = new int[] { -1, -99};
            long actual = Summator.Sum(nums);

            long expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_OneNumber()
        {
            int[] nums = new int[] { 6 };
            long actual = Summator.Sum(nums);

            long expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_ZeroNumbers()
        {
            int[] nums = new int[] {  };
            long actual = Summator.Sum(nums);

            long expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_PositiveAndNegativeNumbers()
        {
            int[] nums = new int[] { -5, 20 };
            long actual = Summator.Sum(nums);

            long expected = 15;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Summator_BigNumbers()
        {
            int[] nums = new int[] { 2000000000, 2000000000 };
            long actual = Summator.Sum(nums);

            long expected = 4000000000;

            Assert.AreEqual(expected, actual);
        }


    }
}
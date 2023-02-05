using NUnit.Framework;
using System.Security.Cryptography;

namespace AverageNumbers.UnitTests
{
    public class AverageNumbersTests
    {
        [Test]
        public void Test_Average_TwoPositiveIntegers() 
        {
            //Arrange
            double[] nums = { 4, 10 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = 7;

            Assert.AreEqual(expected, actual);  
        }

        [Test]
        public void Test_Average_TwoNegativeIntegers()
        {
            //Arrange
            double[] nums = { -4, -10 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = -7;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_TwoPositiveDecimalNumbers()
        {
            //Arrange
            double[] nums = { 5.91, 6.25 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = 6.08;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_TwoNegativeDecimalNumbers()
        {
            //Arrange
            double[] nums = { -5.91, -6.25 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = -6.08;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_PositiveDecimalNumbersAndIntegers()
        {
            //Arrange
            double[] nums = { 5.91, 6.25, 4, 10 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = 6.54;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_NegativeDecimalNumbersAndIntegers()
        {
            //Arrange
            double[] nums = { -5.91, -6.25, -4, -10 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = -6.54;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_PositiveAndNegativeDecimalNumbers()
        {
            //Arrange
            double[] nums = { -5.91, -6.25, 2.06, 102.34 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            Assert.That(actual, Is.InRange(23.05, 23.07));
        }

        [Test]
        public void Test_Average_MixNumbers()
        {
            //Arrange
            double[] nums = { -2.84, 18, 85.58, 102.34, -94 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            Assert.That(actual, Is.EqualTo(21.815999999999995));
        }

        [Test]
        public void Test_Average_ZeroNumbers()
        {
            //Arrange
            double[] nums = { };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = double.NaN;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_OneNumber()
        {
            //Arrange
            double[] nums = { 256 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = 256;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_BigNumbers()
        {
            //Arrange
            double[] nums = { 2000000000, 2000000000, 4000000000, 4000000000 };

            //Act
            double actual = AverageNumbers.Average(nums);

            //Assert
            double expected = 3000000000;

            Assert.AreEqual(expected, actual);
        }
    }
}
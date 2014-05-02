using NUnit.Framework;

namespace PracticeFS.Tests
{
	[TestFixture]
    public class FsTests
    {
		[Test]
		public void DeclaringAPersonReturnsFirstName()
		{
			var person = new BasicMath.Person("Adam","Krieger");

			var firstName = person.First;

			Assert.AreEqual("Adam", firstName);
		}

		[Test]
		public void MultiplyingValuesWorksAsExpected()
		{
			const int x = 4;
			const int y = 5;

			var result = BasicMath.multiplyXandY(x, y);

			Assert.AreEqual(20, result);
		}

		[Test]
		public void TwoIsAFactorOfFour()
		{
			var result = BasicMath.isDivisor(2, 4);

			Assert.True(result);
		}

		[Test]
		public void VerifiedAmicableNumbersAreAmicable()
		{
			var result1 = BasicMath.isAmicable(220);
			var result2 = BasicMath.isAmicable(284);

			Assert.True(result1);
			Assert.True(result2);
		}

		[Test]
		public void VerifiedSumOfAmicableNumbersUpTo10000()
		{
			var result = BasicMath.sumOfAmicableNumbers(10000);

			Assert.AreEqual(31626, result);
		}

    }
}

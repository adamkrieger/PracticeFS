using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFS.Tests
{
	[TestFixture]
    public class FSTests
    {
		[Test]
		public void DeclaringAPersonReturnsFirstName()
		{
			var person = new FSSource.Person("Adam","Krieger");

			var firstName = person.First;

			Assert.AreEqual("Adam", firstName);
		}

		[Test]
		public void MultiplyingValuesWorksAsExpected()
		{
			var x = 4;
			var y = 5;

			var result = FSSource.multiplyXandY(x, y);

			Assert.AreEqual(20, result);
		}

		[Test]
		public void TwoIsAFactorOfFour()
		{
			var result = FSSource.isFactor(2, 4);

			Assert.True(result);
		}
    }
}

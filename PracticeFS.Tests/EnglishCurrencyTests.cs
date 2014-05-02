using NUnit.Framework;

namespace PracticeFS.Tests
{
	[TestFixture]
	public class EnglishCurrencyTests
	{
		[Test]
		public void AbleToSortValuesDescending()
		{
			var coins = new[]{5,10,2,50};

			var sortedCoins = EnglishCurrency.sortCoins(coins);

			Assert.AreEqual(new[]{50,10,5,2},sortedCoins);
		}
	}
}
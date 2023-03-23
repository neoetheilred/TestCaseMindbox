namespace TestCaseMindbox.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestCircle()
		{
			Assert.AreEqual(SquareCalculations.Circle(10), 100 * Math.PI);
			Assert.AreEqual(SquareCalculations.Circle(0), 0);
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => SquareCalculations.Circle(-0.1));
		}

		[TestMethod]
		public void TestTriangle()
		{
			Assert.AreEqual(SquareCalculations.Triangle(3, 4, 5), 6);
		}
	}
}
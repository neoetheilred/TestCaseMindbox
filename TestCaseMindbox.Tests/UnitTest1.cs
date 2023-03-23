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
			Assert.IsFalse(SquareCalculations.TriangleExists(1, 1, 100));
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => SquareCalculations.Triangle(-1, 1, 1));
		}
	}

	[TestClass]
	public class TestObjects
	{
		[TestMethod]
		public void TestTriangle()
		{
			Assert.AreEqual(new Triangle(3, 4, 5).Square, SquareCalculations.Triangle(3, 4, 5));
			Assert.IsTrue(new Triangle(0.3, 0.4, 0.5).IsRight);
			Assert.IsFalse(new Triangle(1, 0.5, 0.5).IsRight);
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 0.44444, 0.5));
		}

		[TestMethod]
		public void TestCircle()
		{
			Assert.AreEqual(new Circle(5).Square, SquareCalculations.Circle(5));
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-1));
		}
	}
}
namespace TestCaseMindbox
{
	public static class SquareCalculations
	{
		/// <summary>
		/// Calculates square of a circle with given radius.
		/// </summary>
		/// <param name="radius">Only non-negative values are allowed</param>
		/// <returns>square of a circle with given radius</returns>
		/// <exception cref="ArgumentOutOfRangeException">Raised when radius is negative</exception>
		public static double Circle(double radius)
		{
			if (radius < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(radius));
			}
			return radius * radius * Math.PI;
		}

		/// <summary>
		/// Calculates square of a triangle with given sides.
		/// Degenerate triangles are allowed (triangles with one or more zero-lengths sides).
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns>square of triangle with given sides lengths</returns>
		/// <exception cref="ArgumentOutOfRangeException">Raised when one or more of given lengths are negative</exception>
		public static double Triangle(double a, double b, double c) 
		{
			if (a < 0 || b < 0 || c < 0)
			{
				throw new ArgumentOutOfRangeException("");
			}
			var p = (a + b + c) * 0.5;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}
	}
}
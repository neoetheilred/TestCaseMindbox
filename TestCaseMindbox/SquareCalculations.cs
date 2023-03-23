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
			if (!TriangleExists(a, b, c))
			{
				throw new ArgumentOutOfRangeException("");
			}
			var p = (a + b + c) * 0.5;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}

		/// <summary>
		/// Checks if triangle exists.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		public static bool TriangleExists(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0)
			{
				return false;
			}
			var sorted = new[] { a, b, c }.OrderBy(x => x).ToArray();
			return sorted[0] + sorted[1] >= sorted[2];
		}
	}

	/// <summary>
	/// Defines an interface of a solid square of which can be evaluated
	/// </summary>
	public interface ISquareEvaluable
	{
		double Square { get; }
	}

	/// <summary>
	/// Defines a triangle type.
	/// Provides square evaluation and checks if Triangle is right
	/// </summary>
	public class Triangle : ISquareEvaluable
	{
		public double Square { get; private set; }
		public bool IsRight { get; private set; }
		public Triangle(double a, double b, double c)
		{
			Square = SquareCalculations.Triangle(a, b, c);

			// Checking if triangle is right
			var sides = new[] { a, b, c }.OrderBy(x => x).ToArray();
			if (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
			{
				IsRight = true;
			}
		}
	}

	/// <summary>
	/// Defines a circle type, provides square evaluation.
	/// </summary>
	public class Circle : ISquareEvaluable
	{
		public double Square { get; private set; }

		public Circle(double radius)
		{
			Square = SquareCalculations.Circle(radius);
		}
	}
}
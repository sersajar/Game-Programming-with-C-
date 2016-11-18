using System;

namespace FloatingPointNumbers
{
	/// <summary>
	/// Demonstrates floating point numbers
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Demonstrates floating point numbers
		/// </summary>
		/// <param name="args">command-line args</param>
		public static void Main (string[] args)
		{
			// declare variables
			int score = 1356;
			int totalSecondsPlayed = 10000;

			// calculate and display result
			float pointsPerSecond = (float)score / totalSecondsPlayed;
			Console.WriteLine("Points per second: " + pointsPerSecond);

			Console.WriteLine();
		}
	}
}

using System;

namespace IntegerDataTypes
{
	/// <summary>
	/// Demonstrates integer data types
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Demonstrates integer data types
		/// </summary>
		/// <param name="args">command-line args</param>
		public static void Main (string[] args)
		{
			// declare integer variable and constant
			int totalSecondsPlayed = 100;
			const int SecondsPerMinute = 60;

			// calculate minutes and seconds
			int minutes = totalSecondsPlayed / SecondsPerMinute;
			int seconds = totalSecondsPlayed % SecondsPerMinute;

			// print results
			Console.WriteLine("Minutes: " + minutes);
			Console.WriteLine("Seconds: " + seconds);

			Console.WriteLine();
		}
	}
}

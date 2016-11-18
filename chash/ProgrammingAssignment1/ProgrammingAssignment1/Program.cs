using System;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Calculates the distance between two points and the angle between those points
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Calculates the distance between two points and the angle between those points
        /// </summary>
        /// <param name="args">command-line args</param>
        public static void Main (string[] args)
        {
            //Printing welcome message
            Console.WriteLine ("Hello there, this application will calculate the distance" +
                " between two points and the angle between those points.");
            Console.WriteLine ();

            //Get, parse and store the values of the points in variables
            Console.WriteLine("Enter the first X point:"); //Prompt
            float point1x = float.Parse (Console.ReadLine ()); //Get, parse and declare

            Console.WriteLine("Enter the first Y point:");
            float point1y = float.Parse (Console.ReadLine ());

            Console.WriteLine("Enter the second X point:");
            float point2x = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Enter the second Y point:");
            float point2y = float.Parse (Console.ReadLine ());

            Console.WriteLine ();

            //calculate the deltaX and deltaY between the 2 points
            double deltaX = point2x - point1x;
            double deltaY = point2y - point1y;

            //Printing your 2 points
            Console.WriteLine ("Point1(X,Y): " + point1x + "," + point1y);
            Console.WriteLine ();
            Console.WriteLine ("Point2(X,Y): " + point2x + "," + point2y);
            Console.WriteLine ();


            //calculate the distance between the 2 points using the Pythagorean Theorem
            // Pythagorean Theorem: A² = B² + C²
            double distance = Math.Sqrt (Math.Pow (deltaX,2) + Math.Pow (deltaY,2));


            //calculate the angle (0 degrees is direclty to right)
            double radians = Math.Atan2 (point2y-point1y, point2x-point1x);
            double angle = radians * (180 / Math.PI);


            //Printing formated distance and angle
            Console.WriteLine ("Distance between Point1 and Point2 is: " + distance.ToString ("N3"));
            Console.WriteLine ();
            Console.WriteLine ("The angle in degrees is: " + angle.ToString ("N3"));
            Console.WriteLine ();

        }
    }
}

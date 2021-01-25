using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a= 17;
            var b = 4;
            var addition = a + b;
            var subtraction = a - b;
            var multiplication = b * a;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(quotient);
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}.");
            
            Console.WriteLine($"What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with the radius {radius} is {area}");
        }

        public static double AreaOfCircle(double radius)
        {
           return Math.PI * (radius * radius);
        }
    }
}

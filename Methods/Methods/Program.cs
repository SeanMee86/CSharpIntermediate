using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void UseOut()
        {
            int number;
        var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed...");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, 3, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"X: {point.X}, Y: {point.Y}");

                point.Move(20, 30);
                Console.WriteLine($"X: {point.X}, Y: {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred...");
            }
        }
    }
}

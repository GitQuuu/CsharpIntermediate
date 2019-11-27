using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);

            if (result == true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }

        static void UseParams()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2));

            Console.WriteLine(calculator.Add(1, 2, 3, 4));


            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoints()
        {
            try
            {
                Point point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at X={point.X} and Y={point.Y} ");

                point.Move(null);
                Console.WriteLine($"Point is at X={point.X} and Y={point.Y} ");



            }
            catch (Exception)
            {
                Console.WriteLine("An unexppected error occured");
            }

        }
    }
}

        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Program
    {

    

        static void Main(string[] args)
        {
            Point point = new Point(100,200);
            point.Move(5, 10);

            Console.WriteLine($"Point is at X={point.X} and Y={point.Y} ");
            

            Console.ReadLine();
        }


    }
}


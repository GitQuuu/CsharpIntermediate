using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, Name);
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";

            person.Introduce("Mosh");


            Console.ReadLine();
        }


    }
}

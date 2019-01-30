using System;

namespace Properites
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime( 2013, 1, 1);
            System.Console.WriteLine(person.Age);
        }
    }
}

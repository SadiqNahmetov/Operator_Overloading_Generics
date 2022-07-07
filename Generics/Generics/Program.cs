using Generics.Models;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(5);
            Kelvin kelvin = celsius;
            Console.WriteLine(kelvin.Degree);
        }
    }

 }

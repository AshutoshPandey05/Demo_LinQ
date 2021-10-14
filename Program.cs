using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Implementation in C#!!");
            int[] scores = new int[] { 56, 78, 47, 87,34,78 };
            string[] cities = new string[] { "Agra", "Banaras", "Delhi", "Kolkata", "Banglore" };

            IEnumerable<int> scoreQuery =
            from score in scores
            where score > 50
            orderby score descending
            select score;

            IEnumerable<string> cityQuery =
           from city in cities
           where city is "Delhi"
           
           select city;

            foreach (int i in scoreQuery)
            {
                Console.WriteLine( "Value is: " + i );
            }

            foreach (var item in cityQuery)
            {
                Console.WriteLine(item is "\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the collections of items shown below, use LINQ to build the requested collection, and 
            // then Console.WriteLine() each item in that resulting collection.

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
                {
                    "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
                };

            IEnumerable<string> LFruits = from fruit in fruits
                                              // where fruit[0] == 'L'
                                          where fruit.StartsWith("L")
                                          select fruit;
            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

            // foreach(int n in fourSixMultiples)
            // {
            //     Console.WriteLine(n);
            // }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();

            // foreach(string name in descend)
            // {
            //     Console.WriteLine(name);
            // }

            // Output how many numbers are in this list
            List<int> numberss = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            // Console.WriteLine($"{numberss.Count}");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            // Console.WriteLine($"{purchases.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            // Console.WriteLine($"{prices.Max()}");

            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
        }
    }
}


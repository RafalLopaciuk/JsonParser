using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonParser.Models;

namespace JsonParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseJson List = new ParseJson("Data/generatedData.json");

            Console.WriteLine("There are " + List.getFemaleCount() + " women and " + List.getMaleCount() + " men in this data");
            Console.WriteLine("The average age is: " + List.getAverageAge());

            Console.ReadKey();
        }
    }
}

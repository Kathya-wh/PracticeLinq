using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsNames = { "ford", "Lexus", "Toyota" };

            var carSpaces = from car in carsNames
                           where car.Contains("o")
                           orderby car descending
                           select car;

            foreach (var i in carSpaces)
            {
                Console.WriteLine(i);
            }


            
            var games = new List<string> {"CandyCrush", "Minecraft", "Forza", "FrootLoop"};

            IEnumerable<string> gameNameLength = games.OrderByDescending(x => x.Length);

            foreach(var i in gameNameLength)
            {
                Console.WriteLine(i);
            }










        }
    }
}

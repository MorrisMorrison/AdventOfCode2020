using System;
using AdventOfCode2020.Star1;


namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventOfCode2020.Star1.Star1 star1 = new AdventOfCode2020.Star1.Star1();
            Console.WriteLine(star1.FindShit());

            AdventOfCode2020.Star2.Star2 star2 = new AdventOfCode2020.Star2.Star2();
            Console.WriteLine(star2.CountShit());

            
            AdventOfCode2020.Star3.Star3 star3 = new AdventOfCode2020.Star3.Star3();
            Console.WriteLine(star3.CountTrees());
        
        }
    }
}

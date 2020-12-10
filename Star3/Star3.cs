using System.IO;
using System.Linq;
using System.Security.AccessControl;
namespace AdventOfCode2020.Star3
{
    public class Star3
    {
        public int CountTrees() {
            string[] input = File.ReadAllLines("Star3/input.txt");
            char[][] vs = input.Select(line => line.ToCharArray()).ToArray();
            int treeCount = 0;
            int position = 3;

            for (int row = 1; row < vs.Count(); row++){
                if (position > vs[row].Count() -1 ) position = position - vs[row].Count();
                if (vs[row][position] == '#') treeCount++;
                    row ++;
                    position += 3;
            }


            return treeCount;
        }
    }
}
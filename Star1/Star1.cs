using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Star1
{
    public class Star1
    {


        public Star1(){

        }
        
        public int FindShit(){
            int[] n =  File.ReadAllLines("Star1/input.txt").Select(i => int.Parse(i)).ToArray();
            // find the 2 entries that add up to 2020
            // (int, int) p = FindCandidatesDouble(n);
            // if (p.Item1 != 0 && p.Item2 != 0) return p.Item1 * p.Item2;
 
            (int, int, int) p = FindCandidatesTriple(n);
            if (p.Item1 != 0 && p.Item2 != 0 && p.Item3 != 0) return p.Item1 * p.Item2 * p.Item3;


            // mutliply them
            // return result
        
            return 0;
        }


        public (int, int) FindCandidatesDouble(int[] n){
            for (int i = 0; i < n.Length; i++){
                for (int j = 0; j < n.Length; j++){
                    if (n[i] + n[j] == 2020) return (n[i], n[j]);
                }
            }

            return (0,0);
        }

        public (int,int,int)FindCandidatesTriple(int[] n){
            for (int i = 0; i < n.Length; i++){
                for (int j = 0; j < n.Length; j++)                {
                    for (int k =0; k < n.Length; k++){
                        if (n[i] + n[j] + n[k] == 2020) return (n[i], n[j], n[k]);
                    }
                }
            }

            return (0,0,0);
        }

    }

}
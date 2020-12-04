using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode2020.Star2
{
    public class Star2
    {
        
        public int CountShit(){
            int validPasswordCount = 0;
            string[] lines = File.ReadAllLines("Star2/input.txt");
            foreach (string line in lines){
                string[] vs = line.Split(":");
                string policy = vs[0];
                string password = vs[1].Trim();
                PasswordPolicy passwordPolicy = ParsePasswordPolicy(policy);
                bool isPasswordValid = passwordPolicy.Validate2(password);
                if (isPasswordValid) validPasswordCount++;
            }

            return validPasswordCount;
        }

        public PasswordPolicy ParsePasswordPolicy(string policy) => new PasswordPolicy(){    
                From = int.Parse(policy.Split("-")[0]),
                To = int.Parse(policy.Split("-")[1].Split(" ")[0]),
                Character = policy.Split("-")[1].Split(" ")[1]
            };

    }

    public class PasswordPolicy{
        public int From {get;set;}
        public int To {get;set;}
        public string Character {get;set;}

        public bool Validate(string password) => password.ToCharArray().ToList().Count(character => character.Equals(char.Parse(Character))) >= From
        && password.ToCharArray().ToList().Count(character => character.Equals(char.Parse(Character))) <= To;   

        public bool Validate2(string password) => (password.ElementAt(From -1) == char.Parse(Character) && password.ElementAt(To-1) != char.Parse(Character))
         || password.ElementAt(To -1) == char.Parse(Character) && password.ElementAt(From-1) != char.Parse(Character);
    }
}
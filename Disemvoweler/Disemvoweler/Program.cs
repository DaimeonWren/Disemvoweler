using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            DisemVoweler("Nickleback is my favorite band. Thier songwriting can't be beat!\n \n");
             DisemVoweler("How many bears could bear grylls grill if a bear grylls could grill bears.\n \n");
             DisemVoweler("I'm a coding ninja, baby. I make the functios and I make the calls.\n \n");
       Console.ReadKey();
        }

        static void DisemVoweler(string input)
        {
            string vowels = "aeiou";    
            string cons = "bcdfghjklmnpqrstvwxyz";
            string newVowels = string.Empty;
            string newCons = string.Empty;
            foreach (char tw in input.ToLower())
            {
                if (vowels.Contains(tw))
                {
                    newVowels = newVowels + tw;
                }

                else if (cons.Contains(tw))
                {
                    newCons = newCons + tw;
                }
                else if (tw == ' '){}
                else {newCons = newCons + tw;}
            } Console.WriteLine(input);
            Console.WriteLine(newCons);
            

        }
    }
}

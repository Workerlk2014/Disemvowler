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
            //Calling Disemvoweler with strings
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            //keeps the window open 
            Console.ReadKey();
        }
        //Function Disemvowler is created with a string variable "inString"
        static void Disemvoweler(string inString)
        {
            //Prints out the original "inString" Parameter
            Console.WriteLine("Original: " + inString);
            //sets a variable called "invowels" and leaves it blank
            var inVowels = "";
            //sets a variable called "inConstants" and leaves it blank
            var inConstants = "";
            //Takes the current "inString" input and changes all characters to lowercase
            var lower = inString.ToLower();
            //Creates a Loop to take characters from the input to select it individually for the if statement
            for (var i = 0; i <= inString.Length - 1; i++)
            {
                //Checks the i variable for a vowel or special character
                if (lower[i].ToString() == "a" || lower[i].ToString() == "i" || lower[i].ToString() == "e" || lower[i].ToString() == "o" || lower[i].ToString() == " " || lower[i].ToString() == "." || lower[i].ToString() == "," || lower[i].ToString() == "?" || lower[i].ToString() == "'" || lower[i].ToString() == "!")
                {
                    //if true, adds the character to "inVowels
                    inVowels = inVowels + lower[i].ToString();
                }
                else
                {
                    //else, adds the character to "inConstants
                    inConstants = inConstants + lower[i].ToString();
                }
                    
            }

            //prints out the "inString" parameter disemvoweled
            Console.WriteLine("Disemvoweled: " + inConstants);

        }
    }
}

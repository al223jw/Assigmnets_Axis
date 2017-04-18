using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // A string is used to store the text.
            string text = "Alice looked at the jury-box, and saw that, in her haste, she had put the Lizard in head downwards, and the poor little thing was waving its tail about in a melancholy way, being quite unable to move. She soon got it out again, and put it right; 'not that it signifies much,' she said to herself; 'I should think it would be QUITE as much use in the trial one way up as the other.' As soon as the jury had a little recovered from the shock of being upset, and their slates and pencils had been found and handed back to them, they set to work very diligently to write out a history of the accident, all except the Lizard, who seemed too much overcome to do anything but sit with its mouth open, gazing up into the roof of the court.";

            // Asks user in the console to write a letter, then press enter.
            Console.WriteLine("Enter a letter and press enter to search for it in the text.");

            // Reads the line that was entered in console and saves it in a variable.
            string searchVariable = Console.ReadLine();

            // Calls the function HasSubString to see if the letter exists in the text then saves the amount in a variable.
            int amountOfLetters = HasSubString(searchVariable, text);

            // Prints the result for the letter.
            Console.WriteLine("The letter " + searchVariable + " was found: " + amountOfLetters + " times in the text.");
        }

        // A function to loop through the text and compare it to the searched letter.
        private static int HasSubString(string _searchVariable, string _text)
        {
            // Counter to keep count of hits.
            int count = 0;

            // Converting the string to a char array to get all letters seperated from each other.
            var textArray = _text.ToCharArray();

            // Loops through all the chars in the array.
            foreach(char c in textArray)
            {
                // Compares a char as a string with the searched letter.
                if(c.ToString() == _searchVariable)
                {
                    // Adds the count if statement is true.
                    count++;
                }
            }

            // Returns the count.
            return count;
        }
    }
}

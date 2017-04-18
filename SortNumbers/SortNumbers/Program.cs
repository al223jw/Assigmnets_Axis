using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            // The amount of numbers declares how many numbers there is in the list.(The number can be changed to any positive whole number in the scope of an int)
            int amountOfNumbers = 100;

            // A variable to save the sortedList in.
            List<int> sortedList;

            // Using the Random class to generate a new random number.
            Random randomNumber = new Random();

            // Creating a List which will contain int numbers.
            List<int> numberList = new List<int>();

            // Simple loop that adds random numbers to the list for the abount of amountOfNumbers.
            for (int i = 0; i < amountOfNumbers; i++)
            {
                // Here the random number gets added to the List and also the scope is set to 1 - 100.
                numberList.Add(randomNumber.Next(1, 100));
            }

            // A nice way to print to the console. (The use of Console.WriteLine makes spaces in the console window to make it easy to see)
            Console.WriteLine("List with random numbers: ");
            printList(numberList);
            Console.WriteLine();

            Console.WriteLine("Press Enter to sort the numbers in ascending order or ESC to exit.");
            Console.WriteLine();

            // Press L to use Low to High sort function press H for High to low sort function.
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                sortedList = SortListLowToHigh(numberList);

                // A nice print to the console.
                Console.WriteLine("List with numbers in ascending order: ");
                Console.WriteLine();
                printList(sortedList);
            }

            // Exits the console application when Escape is pressed.
            if(Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
        }

        // Prints a list in a nice way.
        private static void printList(List<int> _numberList)
        {
            foreach (int number in _numberList)
            {
                Console.Write(number + ", ");
            }
            // Adds extra space for a nice view.
            Console.WriteLine();
        }

        // Takes any List containing int numbers and sorts it Low to High.
        private static List<int> SortListLowToHigh(List<int> _numberList)
        {
            // Creating new List that will be returned.
            List<int> sortedList = new List<int>();

            // A holder to save a number in.
            int numberHolder = 0;

            // The code will run until numberList is empty and all numbers have been added to the sortedList. 
            while (_numberList.Count != 0)
            {
                // This loop will loop until variable i is equal to the count of numberList.
                for (int i = 0; i < _numberList.Count; i++)
                {
                    // Saving the number located at first place in the List.
                    int numberHolder2 = _numberList[0];

                    // Comparison if the first number in the list is larger than the place in the List provided by the number from the loop.
                    if (_numberList[0] > _numberList[i])
                    {
                        // If the number at position i was smaller than the number at position 0 they will change places.
                        _numberList[0] = _numberList[i];
                        _numberList[i] = numberHolder2;
                    }
                }

                // The numberholder will now get the number placed at position 0 in the List which now should be the currently smallest number in the List.
                 numberHolder = _numberList[0];

                // Then the place at 0 in the list will change place with the number at the last position in the list. (we subtract 1 from the count due to an array starts at 0)
                _numberList[0] = _numberList[_numberList.Count - 1];
                _numberList[_numberList.Count - 1] = numberHolder;

                // Adding the number at last position from the List which now should be the smallest number.
                sortedList.Add(_numberList[_numberList.Count - 1]);

                // Removing the number at last position in the List since this have now been added in the new sortedList.
                _numberList.RemoveAt(_numberList.Count - 1);
            }

            // Returning the new List.
            return sortedList;
        }
    }
}

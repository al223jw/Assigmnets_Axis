using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list to store all possible numbers which depends on numberAmount variable. 
            IList<int> numberList = new List<int>();

            // The amount of numbers in list.
            int numberAbount = 36;

            // String to store the lottery ticket.
            string lotteryTicket = "";
            // Variable used to generate a new random number.
            Random random = new Random();

            // Adds numbers to the list.
            for (int i = 1; i < numberAbount; i++)
            {
                numberList.Add(i);
            }

            // Creates a IEnumerable<int> variable to store the randomized numbers from the number list.
            IEnumerable<int> randomNumbers = numberList.OrderBy(x => random.Next()).Take(7);

            // Converts the IEnumerable<int> to a array with the numbers.
            var numberArray = randomNumbers.ToArray();

            // A loop to generate the ticket. Takes all numbers in array and adds them to a string.
            foreach (int n in numberArray)
            {
                // A nice way to present the ticket.
                lotteryTicket += n + ", ";
            }

            // Tells user to press Enter to generate a ticket.
            Console.WriteLine("Press Enter to generate a lottery ticket.");
            // Looks if user press Enter.
            if(Console.ReadKey().Key == ConsoleKey.Enter)
            // Prints the ticket.
            Console.WriteLine(lotteryTicket);
        }
    }
}

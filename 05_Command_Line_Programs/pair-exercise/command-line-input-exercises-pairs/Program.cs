using System;

namespace command_line_input_exercises_pairs
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

        C:\Users> MakeChange

        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of the bill: ");
            string billedAmount = Console.ReadLine();
            Console.Write("Please enter	the	amount tendered: ");
            string tenderedAmount = Console.ReadLine();

            double billedAmountParsed = double.Parse(billedAmount);
            double tenderedAmountParsed = double.Parse(tenderedAmount);

            Console.Write($"The change required is: {tenderedAmountParsed - billedAmountParsed} ");

            Console.ReadLine();
        }
        
    }
}

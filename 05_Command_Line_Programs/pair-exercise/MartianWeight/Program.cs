using System;

namespace MartianWeight
{
    /*
    In case you've ever pondered how much you weight on Mars, here's the calculation:
    Wm = We* 0.378
    where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

    Write a command line program which accepts a series of Earth weights from the user  
    and displays each Earth weight as itself, and its Martian equivalent.


    C:\Users> MartianWeight  
    Enter a series of Earth weights (space-separated): 98 235 185

    98 lbs.on Earth, is 37 lbs.on Mars.
    235 lbs.on Earth, is 88 lbs.on Mars.
    185 lbs.on Earth, is 69 lbs.on Mars. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of earth weights (space-seperated): ");
            string userInput = Console.ReadLine();
            string[] earthWeightsString = userInput.Split(" ");
            int[] earthWeights = new int[earthWeightsString.Length];
            int[] marsWeights = new int[earthWeightsString.Length];
            Console.WriteLine();
            for (int i = 0; i < earthWeights.Length; i++)
            {
                earthWeights[i] = int.Parse(earthWeightsString[i]);
                marsWeights[i] = (int)(earthWeights[i] * 0.378);
                Console.WriteLine($"{earthWeights[i]} lbs. on Earth is {marsWeights[i]} lbs. on Mars.");
            }

            


            Console.ReadLine();
        }
    }
}

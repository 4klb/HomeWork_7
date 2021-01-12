using System;

namespace HomeWork_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var rangeOfArray = new RangeOfArray();

            string incomingNumber = Console.ReadLine();
            int temporaryLowerNumber;
            int.TryParse(incomingNumber, out temporaryLowerNumber);
            rangeOfArray.LowerIndex = temporaryLowerNumber;

            incomingNumber = Console.ReadLine();
            int temporaryUpperNumber;    
            int.TryParse(incomingNumber, out temporaryUpperNumber);
            rangeOfArray.UpperIndex = temporaryUpperNumber;

            incomingNumber = Console.ReadLine();
            int.TryParse(incomingNumber, out var length);

            int[] arrayOfNumbers = new int[10];
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var range = new Range(temporaryLowerNumber, temporaryUpperNumber);
            arrayOfNumbers = numbers[range];

            Console.WriteLine();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i]);
            }
        }
    }
}

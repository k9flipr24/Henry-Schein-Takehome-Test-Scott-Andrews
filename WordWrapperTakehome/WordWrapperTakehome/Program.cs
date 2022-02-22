using System;

namespace WordWrapperTakehome
{
    class Program
    {
        /*
         * This main is the driver for the program. It lets you enter sentences, and then column count, and displays the output. If user gives a 0 for sentence, then it quits the program
         */
        static void Main(string[] args)
        {
            String inputString = "";
            while(true)
            {
                Console.WriteLine("Please enter a string to be wrapped, or 0 to quit:");
                inputString = Console.ReadLine();
                if (inputString == "0")
                    break;
                Console.WriteLine("Please enter column width:");
                int numColumns = int.Parse(Console.ReadLine());
                WordWrapper.wrap(inputString, numColumns);
                Console.WriteLine();
            }
        }
    }
}

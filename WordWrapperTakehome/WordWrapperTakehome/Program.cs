using System;

namespace WordWrapperTakehome
{
    class Program
    {
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

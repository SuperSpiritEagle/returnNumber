using System;

namespace Readint
{
    class Program
    {
        static int returnNumber()
        {
            bool isWork = true;
            string userInput;
            int number = 0;

            while (isWork)
            {
                Console.WriteLine("Введите число");
                userInput = Console.ReadLine();

                Console.WriteLine();

                bool isReadintResult = int.TryParse(userInput, out number);

                if (isReadintResult == true)
                {
                    isWork = false;
                }
                else
                {
                    continue;
                }
            }

            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(returnNumber());
        }
    }
}

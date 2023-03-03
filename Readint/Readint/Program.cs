using System;

namespace Readint
{
    class Program
    {
        static int GetNumber()
        {
            bool isWork = true;
            string userInput;
            int number = 0;

            while (isWork)
            {
                Console.WriteLine("Введите число");

                userInput = Console.ReadLine();

                Console.WriteLine();

                bool isNumberResult = int.TryParse(userInput, out number);

                if (isNumberResult == true)
                {
                    isWork = false;
                }
            }

            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumber());
        }
    }
}

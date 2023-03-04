using System;

namespace Readint
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetNumber());

        }

        private static int GetNumber()
        {
            string userInput = "";
            int number = 0;

            while (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Введите число");
                userInput = Console.ReadLine();
            }

            return number;
        }
    }
}

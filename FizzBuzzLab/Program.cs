using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int userNumber = 0;
            while (userNumber <= 0)
            {
                userNumber = program.userInput();
            }
            for (int i = 1; i <= userNumber; i++)
            {
                Console.WriteLine(program.printNumber(i));
            }
            Console.ReadKey();
        }

        public int userInput()
        {
            Console.WriteLine("Pick a number between 1-300");

            bool onlyNumbers = Int32.TryParse(Console.ReadLine(), out int b);
            if (onlyNumbers == true && b < 300 && b > 1)
            {
                return b;
            }
            else
            {
                return 0;
            }
        }

        public string printNumber(int number)
        {
            string output;

            if (number == 42)
            {
                output = "Answer to the Ultimate Question of Life, the Universe, and Everything";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                output = "Fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                output = "Fizz";

            }
            else if (number % 5 == 0)
            {
                output = "Buzz";
            }
            else
                output = number.ToString();

            return output;
        }
    }
}

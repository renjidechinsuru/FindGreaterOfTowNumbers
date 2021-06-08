using System;

namespace FindGreaterOfTowNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Please enter first Number");
            number1 = Convert.ToInt32(Console.ReadLine()); // This statement is converting the string into int

            Console.WriteLine("Please enter second Number");
            number2 = Convert.ToInt32(Console.ReadLine()); // This statement is converting the strinf into int

                if(number1 > number2)
            {
                Console.WriteLine(number1.ToString()+ " is greater number "+ number2.ToString());
            }

                else
            {
                Console.WriteLine("number2 is greater number");
            }

        }
    }
}

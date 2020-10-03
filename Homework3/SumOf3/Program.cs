using System;

namespace SumOf3
{
    class Program
    {
        //1. Prompt the user to enter 3 different numbers(1 is a valid input and so is 5.5)

        //2. Add all 3 numbers together and output the result displaying 3 decimal places.

        //3. Calculate a second value, where you multiply the sum of the 3 numbers by a constant value of 7.777 (hint: make a constant variable that is type double).

        //4. Compress and save the folder, and submit to Canvas

        const double ConstantValue = 7.777;

        static void Main(string[] args)
        {
            //Narration:
            // This is Participation 3.1 - Sum of 3 numbers
            // Lets start with putting the name at the top of the program
            // Then lets just jump in and ask our user to enter a number
            // And we will do that three times and save their answers in double variables 
            // just in case they like numbers with a decimal. 
            // We are also assuming that they are going to do as we say and enter numbers
            // and not any other characters

            Console.WriteLine("--- Sum of 3 Numbers ---\n\r");

            Console.WriteLine("Please enter a number >>");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\rPlease enter another number >>");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\rPlease enter a third number >>");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Then lets take those variables add them together
            // We could do this right in the cw, but because of the need of the sum for the next 
            double sum = num1 + num2 + num3;
            Console.WriteLine($"\n\rThose numbers added together equal {sum:n2}\n\r");
            Console.WriteLine($"Those numbers mulitplied by the constant {ConstantValue} is {(ConstantValue * sum):n2}");

            Console.ReadKey();
        }
    }
}

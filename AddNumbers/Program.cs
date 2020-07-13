using System;


namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int total;
            int product;

            Console.Write("Enter 1st Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            total = number1 + number2;

            Console.WriteLine("Total is " + total);

            product = number1 * number2;

            Console.WriteLine("Product is " + product);

        }
    }
}

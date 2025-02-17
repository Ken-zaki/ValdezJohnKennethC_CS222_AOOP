using System;

class Program
{
    static void Main()
    {
        int total = 10;

        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0) 
        {
            if (number % 2 == 0) 
            {
                Console.WriteLine("The number is even");
                total += number * number;
                Console.WriteLine(total);
            }
            else 
            {
                Console.WriteLine("The number is odd");
                total += number * number * number;
                Console.WriteLine(total);
            }
        }
        else if (number < 0) 
        {
            Console.Write("Enter an another integer: ");
            int integer = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 0; i < integer; i++) 
            {
                result *= number;
            }

            total += result; 
            Console.WriteLine(total);
        }
        else
        {
            Console.WriteLine("Nothing happened.");
        }
    }
}

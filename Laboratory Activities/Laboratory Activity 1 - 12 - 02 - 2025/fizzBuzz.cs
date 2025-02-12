
using System;

public class FizzBuzz
{
    public static void Main(string[] args)
    {
        int upperbound = 15;
        
        for (int i = 1; i <= upperbound; i++)
         {
            if (i % 3 == 0 && i % 5 == 0) {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0 || i % 5 == 0){
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0 || i % 3 == 0) {
               Console.WriteLine("Buzz");
            }
            else {
                Console.WriteLine(i);
            }
         }
    }
}




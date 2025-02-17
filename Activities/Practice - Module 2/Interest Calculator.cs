using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write ("Enter principal amount: ");
        double value = double.Parse(Console.ReadLine());
        Console.Write ("Enter rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write ("Enter time in a year: ");
        double time = double.Parse(Console.ReadLine());
    
        double interest = value * rate * time / 100;
        Console.Write ("Simple Interest: {0:f}", interest);
    }
}
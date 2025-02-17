using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write ("Enter amount in USD: ");
        double value = double.Parse(Console.ReadLine());
        Console.Write ("Enter exchange rate from USD to EUR: ");
        double rate = double.Parse(Console.ReadLine());
        double amount = value * rate;
        Console.Write ("Amount in EUR: {0:f}", amount);
    }
}
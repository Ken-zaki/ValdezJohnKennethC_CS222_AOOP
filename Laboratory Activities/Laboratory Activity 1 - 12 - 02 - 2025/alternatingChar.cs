
using System;

public class alternatingChar
{
    public static void Main(string[] args)
    {
     Console.Write("First Character: ");
     char firstChar = char.Parse(Console.ReadLine());
     
     Console.Write("Second Character: ");
     char secondChar = char.Parse(Console.ReadLine());
     
     Console.Write("Enter Size: ");
     int size = int.Parse(Console.ReadLine());
     
     for (int i = 0; i < size; i++ ) {
         for (int j = 0; j < i; j++) {
             Console.Write("-");
         }
         if (i % 2 == 0){
             Console.WriteLine(firstChar);
         } else {
             Console.WriteLine(secondChar);
         }
     }
    }
}
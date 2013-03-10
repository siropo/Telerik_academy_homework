using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", number);   // Decimal

        Console.WriteLine(number.ToString("X")); // Hexadecimal

        Console.WriteLine("{0,15:P}", number); // Percentage

        Console.WriteLine("{0,15:E}", number); // Scientific notation
    }
}
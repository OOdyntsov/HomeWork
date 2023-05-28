
using System;
using System.Net.NetworkInformation;

namespace Homework2;
class Program
{
    static void Main(string[] args)

    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int product = num1 * num2 * num3;
        Console.WriteLine("The product of the three numbers is: " + product);

        int temp;

        Console.WriteLine($"sum of two numbers = {num1 + num2}");
        Console.WriteLine($"dividing two numbers = {num1 / num2}");

        Console.WriteLine($"-1 + 4 * 6  = {(-1d + 4d * 6d)}");
        Console.WriteLine($"(35 + 5) % 7) = {(35 + 5) % 7}");
        Console.WriteLine($"(14 + -4 * 6 / 11) = {(14d + -4d * 6d / 11d)}");
        Console.WriteLine($"(14 + -4 * 6 / 11) = {2d + 15d / 6d * 1d - 7d % 2d}");

        Console.WriteLine($"Before swaping = {num1} , {num2}");
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"After swaping = {num1} , {num2}");


    }
}


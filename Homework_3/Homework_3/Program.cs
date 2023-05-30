using System;
namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 

            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            bool result = (num1 * num2) < 0;

            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion
            #region task2

            Console.ReadLine();
            if (num1 == 20 || num2 == 20 || (num1 + num2 == 20))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion
            #region task3

            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            //
            #region task5
            int n, sum = 0, remainder;

            Console.Write("Enter an integer: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                remainder = n % 10;
                sum += remainder;
                n /= 10;
            }

            Console.WriteLine($"The sum of the digits is: {sum}");

            #endregion
            #region task4 

            int primeNumberCounter = 0, primeNumberSum = 0;

            for (int number = 2; primeNumberCounter < 500; number++)
            {
                bool isPrime = true;
                for (int g = 2; g < number; g++)
                {
                    if (number % g == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumberCounter++;
                    primeNumberSum += number;

                }
            }
            Console.WriteLine(primeNumberSum);
            #endregion
        }
    }

}
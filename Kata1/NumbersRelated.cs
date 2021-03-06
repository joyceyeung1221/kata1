﻿using System;
namespace Kata1
{
    public class NumbersRelated
    {
        public static void Step4()
        {
            int input = RequireUserInput();
            Console.WriteLine(PrintSum(input));
        }

        public static void Step5()
        {
            int input = RequireUserInput();
            Console.WriteLine(SumDivisorOf3or5(input));
        }

        public static void Step6()
        {
            Console.WriteLine("Select 1 for computing the sum or 2 for the product of 1,...,n");
            int selection = Convert.ToInt32(Console.ReadLine());
            int input = RequireUserInput();
            object output;
            if (selection == 1) output = PrintSum(input).ToString();
            else if (selection == 2) output = ListAllNumbers(input);
            else output = "Not a valid input";
            Console.WriteLine(output);
        }

        public static void Step7()
        {
            int i = 1;
            while (i <= 12)
            {
                for (int n = 1; n <= 10; n++)
                {
                    Console.WriteLine($"{i} x {n} = {i * n}");
                    if (n == 10)
                    {
                        Console.WriteLine("\n");
                    }
                }
                i++;
            }
        }

        public static void Step8()
        {
            Random getRandom = new Random();
            int secretNumber = getRandom.Next(100);
            int numberOfAttempt = 0;
            int? lastInput = null;
            int input = 0;

            Console.WriteLine("-- Here is a guessing game --");
            while (input != secretNumber)
            {
                input = RequireUserInput();
                Console.WriteLine(secretNumber);
                if (input == lastInput)
                {
                    Console.WriteLine("You have entered the same answer as last attempt :(");
                }
                else
                {
                    Console.WriteLine(input < secretNumber ? "Too small" : "Too large");
                    numberOfAttempt++;
                }
                lastInput = input;
            }
            Console.WriteLine($"Congratulations! You found the correct number on your {numberOfAttempt} attempts!");
        }

        private static int RequireUserInput()
        {
            int input = 0;
            do
            {
                Console.WriteLine("Please enter a number between 1 - 100");
                input = Convert.ToInt32(Console.ReadLine());
            } while (input <= 0 || input > 100);
            return input;
        }

        private static int PrintSum(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            return sum;
        }

        private static int SumDivisorOf3or5(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static string ListAllNumbers(int input)
        {
            int[] numbers = new int[input];
            int i = 1;
            while (i <= input)
            {
                numbers[i - 1] = i;
                i++;
            }
            return String.Join(", ", numbers);
        }
    }

}

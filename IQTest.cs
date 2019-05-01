/*
Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

##Examples :
IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd
*/

using System;
using System.Linq;

public class IQ
{ 
    public static int Test(string numbers)
    {
        int oddPoint = 0;
        int oddTally = 0;
        int evenTally = 0;

        Console.WriteLine("The numbers in this sequence: " + numbers);
        Console.WriteLine("Odd Point has been reset to: " + oddPoint);

        //Take each value in the string and add it to an array
        string[] splitNumbersAsString = numbers.Split(" ");

        // Convert each item in the array into an integer
        int[] splitNumbers = Array.ConvertAll(splitNumbersAsString, int.Parse);

        // Find out if the list is majority EVEN or majority ODD before deciding which 
        foreach (int i in splitNumbers)
        {
            if (i % 2 != 0)
            {
                oddTally ++;
            }

            else
            {
                evenTally ++;
            }
        }

        Console.WriteLine("Even: {0}, Odd: {1}", evenTally, oddTally);

        // Majority EVEN
        if (evenTally > oddTally)
        {
            Console.WriteLine("Handling a list which has a majority of even numbers");

            foreach (int j in splitNumbers)
            {
                oddPoint ++;
                Console.WriteLine("Current number: {0}. Current index: {1}", j, oddPoint);

                if (j % 2 != 0)
                {
                    Console.WriteLine("Found an odd number, '{0}' at position {1} of the array.", j, oddPoint);
                    break;
                }
            }
        }

        // Majority ODD
        else if (oddTally > evenTally)
        {
            Console.WriteLine("Handling a list which has a majority of odd numbers");

            foreach (int k in splitNumbers)
            {
                oddPoint ++;
                Console.WriteLine("Current number: {0}. Current index: {1}", k, oddPoint);

                if (k % 2 != 1)
                {
                    Console.WriteLine("Found an even number, '{0}' at position {1} of the array.", k, oddPoint);
                    break;
                }
            }
        }
        return oddPoint;
    }
}

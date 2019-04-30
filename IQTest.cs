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
            
            Console.WriteLine("Odd Point set to 0");

            //Take each value in the string and add it to an array
            string[] splitNumbersAsString = numbers.Split(" ");
            Console.WriteLine(splitNumbersAsString);

            // Convert each item in the array into an integer
            int[] splitNumbers = Array.ConvertAll(splitNumbersAsString, int.Parse);
            Console.WriteLine(splitNumbers);

            foreach (int i in splitNumbers)
            {
                oddPoint ++;
                Console.WriteLine("'i' is currently: {0}. Index is currently: {1}", i, oddPoint);
                if (i % 2 != 0)
                {
                    Console.WriteLine("Found an odd number, '{0}' at position {1} of the array.", i, oddPoint);
                    break;
                }

            }
            return oddPoint;
             
        }
    }
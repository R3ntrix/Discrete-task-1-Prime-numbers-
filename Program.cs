
/*
 Made by Ahmed Abduljawad Attia
 */

using System;

// prompts and variables
Console.WriteLine("Enter the start of the range: ");
var rangeStart = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the end of the range: ");
var rangeEnd = int.Parse(Console.ReadLine());

Console.WriteLine("Prime numbers between {0} and {1} are: ", rangeStart, rangeEnd);

// methods
static bool IsPrime(int number)
{
    if (number < 2) {return false;}
    bool isPrime = true;

    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
        }

    }

    return isPrime;
}

static int GetPrimeNumbersInRange(int rangeStart, int rangeEnd)
{
    int numberOfPrimeNumbers = 0;

    for (int i = rangeStart; i <= rangeEnd; i++)
    {

        bool isPrime = IsPrime(i);
        if (isPrime)
        {
            numberOfPrimeNumbers++;
            Console.WriteLine(i);
        }

    }
   
    return numberOfPrimeNumbers;
}

// system code
int numberOfPrimeNumbers = GetPrimeNumbersInRange(rangeStart, rangeEnd);

if (numberOfPrimeNumbers > 0)
{
    Console.WriteLine("Number of prime numbers found in the given range: " + numberOfPrimeNumbers);
}
else
{
    Console.WriteLine("No prime numbers were found in the given range! ");
}
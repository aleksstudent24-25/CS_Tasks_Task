using System.Runtime.CompilerServices;
using System.Security.Principal;

public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0) Console.WriteLine($"{a} is an even number");
        else Console.WriteLine($"{a} is an odd number");
    }

    public string GetAInterestingFact(string fact)
    {
        return fact;
    }

    public void SumTwoNumbers()
    {
        long a = 1;
        double b = 2;
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        int a = 0;
        int b = 1;

        Console.Write($"{a}, ");
        Console.Write($"{b}, ");
        for (int i = 0; i < 10; i++)
        {
            int c = a + b;
            if(i < 9) Console.Write($"{c}, ");
            else Console.WriteLine($"{c}");
            a = b;
            b = c;
        }

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    {
        // TODO: reverse the given string
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}

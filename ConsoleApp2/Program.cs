using System;
using System.Text;
using RNE;
using RN;

class Program
{
    static void Main(string[] args)
    {
        int digit1 = 0;
        int digit2 = 0;

        Console.WriteLine("Input number1");
        digit1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input number1");
        digit2 = Convert.ToInt32(Console.ReadLine());

        RomanNumber number1 = new RomanNumber(digit1);
        RomanNumber number2 = new RomanNumber(digit2);

        RomanNumber.Add(number1, number2);
        RomanNumber.Sub(number1, number2);
        RomanNumber.Mul(number1, number2);
        RomanNumber.Div(number1, number2);
    }
}


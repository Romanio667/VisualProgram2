using System;
using System.Text;
using RNE;
using System.Collections.Generic;

public class RomanNumber : ICloneable, IComparable
{
    string number;
    int value;
    public RomanNumber(int n)
    {
        try
        {
            if (n < 0 || n > 3999)
                throw new ArgumentException("Value must be in the range 0 - 3,999.");
            RomanNumberException cvb = new RomanNumberException();
            if (n == 0) cvb.Vod(n);

            ushort[] values = new ushort[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[]
            { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


            StringBuilder result = new StringBuilder();


            for (int i = 0; i < 13; i++)
            {
                while (n >= values[i])
                {
                    n -= values[i];
                    result.Append(numerals[i]);
                }
            }
            number = result.ToString();
            Console.WriteLine(result.ToString());
        }

        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

    }


    public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
    {
        RomanNumber number1;
        try
        {
            string a1 = n1.number;
            char[] arr1 = new char[a1.Length];
            arr1 = a1.ToCharArray();
            int sum1 = 0;
            Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += rimDg1[arr1[i]];
            }

            string a2 = n2.number;
            char[] arr2 = new char[a2.Length];
            arr2 = a2.ToCharArray();
            int sum2 = 0;
            Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += rimDg2[arr2[i]];
            }
            int sum3 = 0;
            sum3 = sum1 + sum2;

            Console.WriteLine(sum3);
            number1 = new RomanNumber(sum3);
        }
        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }
        return number1;
    }


    public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
    {
        RomanNumber number2;
        try
        {
            string a1 = n1.number;
            char[] arr1 = new char[a1.Length];
            arr1 = a1.ToCharArray();
            int min1 = 0;
            Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr1.Length; i++)
            {
                min1 += rimDg1[arr1[i]];
            }

            string a2 = n2.number;
            char[] arr2 = new char[a2.Length];
            arr2 = a2.ToCharArray();
            int min2 = 0;
            Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr2.Length; i++)
            {
                min2 += rimDg2[arr2[i]];
            }
            int min3 = 0;
            min3 = min1 - min2;
            Console.WriteLine(min3);
            number2 = new RomanNumber(min3);
        }
        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        return number2;

    }

    public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
    {
        RomanNumber number3;
        try
        {
            string a1 = n1.number;
            char[] arr1 = new char[a1.Length];
            arr1 = a1.ToCharArray();
            int mul1 = 0;
            Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr1.Length; i++)
            {
                mul1 += rimDg1[arr1[i]];
            }

            string a2 = n2.number;
            char[] arr2 = new char[a2.Length];
            arr2 = a2.ToCharArray();
            int mul2 = 0;
            Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr2.Length; i++)
            {
                mul2 += rimDg2[arr2[i]];
            }
            int mul3 = 0;
            mul3 = mul1 * mul2;

            Console.WriteLine(mul3);
            number3 = new RomanNumber(mul3);
        }
        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        return number3;
    }

    public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
    {
        RomanNumber number4;
        try
        {
            string a1 = n1.number;
            char[] arr1 = new char[a1.Length];
            arr1 = a1.ToCharArray();
            int div1 = 0;
            Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr1.Length; i++)
            {
                div1 += rimDg1[arr1[i]];
            }

            string a2 = n2.number;
            char[] arr2 = new char[a2.Length];
            arr2 = a2.ToCharArray();
            int div2 = 0;
            Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr2.Length; i++)
            {
                div2 += rimDg2[arr2[i]];
            }
            int div3 = 0;
            div3 = div1 / div2;

            Console.WriteLine(div3);
            number4 = new RomanNumber(div3);
        }
        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

        return number4;

    }

    public override string ToString()
    {

        throw new NotImplementedException("The method or operation is not implemented.");
    }

    public object Clone()
    {

        try
        {
            return new RomanNumber(value);
        }
        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

    }

    public int CompareTo(object? obj)
    {
        try
        {
            if (obj is RomanNumber person) return value.CompareTo(person.value);
            else throw new ArgumentException("Некорректное значение параметра");
        }
        catch
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }

    }


    static void Main(string[] args)
    {

        RomanNumber number = new RomanNumber(35);

        Add(number, number);
        Sub(number, number);
        Mul(number, number);
        Div(number, number);
    }

}




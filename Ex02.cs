using System;

namespace SampleConApp1
{
    /* 
     * Variables in C# are based on Common type system of .NET framework.
     * All variables in .NET follow the guidelines defined in common language specification.
     * Varibales in .NET are of two types : Value types, Reference types
     * Value types: primitives and are strucutres
     * Integral types: byte, short, int, long
     * Floating type: float, double
     * Other types: char, boolean, decimal(128bit no.)
     * All data types of C# are implicitly objects of their wrapper types created in .NET. Implicitly they all are objects. The wrapper tpyes provide the functions to perform conversion from one type to another. */
    class Ex02
    {
        static void Main(string[] args)
        {
            int value = 123;
            Console.WriteLine("The value is :" + value);

            double dval = 234.14;
            Console.WriteLine("The double value is: " + dval);

            int bigInt = int.MaxValue;  //We are using the wrapper class' constant value which gives the max value of int
            Console.WriteLine("The max value of int is :" + bigInt);
            Console.WriteLine("Range for byte is: {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Range for short is: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Range for long is: {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Th range of int value is {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Range for float is: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Range for double is: {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Range for decimal is: {0} to {1}", decimal.MinValue, decimal.MaxValue);



        }
    }
}

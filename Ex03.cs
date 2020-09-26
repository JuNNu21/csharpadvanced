using Microsoft.Win32.SafeHandles;
using System;

namespace SampleConApp1
{
    class Ex03
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Enter the age");
        //    int age = int.Parse(Console.ReadLine());
        //    Console.WriteLine("The age is {0}", age);
        //    Console.WriteLine("The age is also " + age);   //both ways 

            float value = 234.234f; //float me f last me
            int intVal = (int)value;  // FORCEFUL CONVERSION
            Console.WriteLine("The value after conversion: " + intVal);

            
            try
            {
                intVal = int.MaxValue;
                long lVal = intVal + 2344; //implicit
                                           //intVal = int(lVal); //not safe
                intVal = Convert.ToInt32(lVal);
                Console.WriteLine(intVal);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid Cast");
            }

        }
    }
}
// ctrl+K C for comment  ctrl+K U for uncomment
//ReadLine method <<< Console class. Used to get the input from the console. It returns a string. But, we can convert the string value to any of the primitive types using Parse method of its wrapper class.
// To convert from one primitive type to another, you could C style casting or Convert class. Convert classss is preferred as it throws an exception if the conversion fails which can be handled by exception handling.

// Casting is safe when there is no possibility of losing the data. Shorter range valus can be casted implicitly to a larger range variable. However, the reverse is not possible, you can explicitly do the conversion using casting. In this case, there are chances of losing a part of the data/ complete data.
// Casting is forceful conversion and u intend to tell the compiler that u are aware of the limitations.

//casting is not Safe all the time, instead u convert class which raises an exception if an arithmetic overflow occurs




    /*
    ReadLine method of the Console class is used to get the input from the Console. It returns a String.
    However U could convert the string value to any of the primitive types using Parse method of its wrapper class. 
    To convert from one primitive type to another, U could use C style casting or Convert class. Convert class is more prefered as it throws an Exception if the conversion fails which u can handle thro Exception Handling.
    Casting is safe when there is no possibility of loosing the data. Shorter range values can be casted implicitly to a larger range variable(No need to cast). However the reverse is not possible, U could explicitly do the conversion using casting. In this case, there are chances of loosing a part of the data or some times the complete data itself.
    Casting is forcefull conversion and U intend to tell the compiler that U R aware of the limitations. 
    int can be implicitly converted to long. long needs to be casted to int if U need to convert to int. 
    casting is not safe all the time, instead use Convert class which raises an Exception if an arithematic overflow occurs. However U should enforece this by setting a compiler setting to Check for arithematic overflows: Project->Properties->Build->Advanced->Check For arithematic overflow/underflow....
    */
//    class Ex03
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Enter the age");
//            //int age = int.Parse(Console.ReadLine());
//            //Console.WriteLine("The age is " + age);

//            float value = 234.234f;//float value
//            int intVal = (int)value;//forcefull conversion and telling the compiler to convert the data..
//            Console.WriteLine("The value after coversion: " + intVal);

//            //intVal = (int)lVal;//casting...
//            try
//            {
//                intVal = int.MaxValue;
//                long lVal = intVal + 2344;//implicit..
//                intVal = Convert.ToInt32(lVal);
//                Console.WriteLine("The value of intVal: " + intVal);
//            }
//            catch (OverflowException ex)
//            {
//                Console.WriteLine(ex.Message);
//                Console.WriteLine("Invalid Cast");
//            }

//        }
//    }

//}
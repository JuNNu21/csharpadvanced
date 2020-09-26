using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp1
{
    class Parameters
    {
        static void simpleFunc(int arg)
        {
            Console.WriteLine("The passed value:" + arg);
            arg += 123; //change is local to the funcn
        }
        static void refFunc(ref int arg)
        {
            arg += 123;
        }
        //static void passByValue()
        //{
        //    int value = 123;
        //    simpleFunc(value);
        //    Console.WriteLine("The value after funcn return is : " + value);
        //}

        //static void passsByRef()
        //{
        //    int value = 432;
        //    refFunc(ref value);
        //    Console.WriteLine("The value after funcn return by ref is : " + value);
        //}

        static void Main(string[] args)
        {
            //passByValue();
            //passsByRef();
            //NewMethod();
            passByParams();
        }

        private static void NewMethod()
        {
            int v1 = 123, v2 = 234;
            double addedNo = 0, subNo = 0, prod = 0, div=0; // no need to div = 0 if out is used
            getArithmeticValues(v1, v2, ref addedNo, ref subNo);
            getProductValues(v1, v2, ref prod, out div);
            Console.WriteLine("The added value: " + addedNo);
            Console.WriteLine("The sub value: " + subNo);
            Console.WriteLine("The product value: " + prod);
            Console.WriteLine("The divided value: " + div);
        }
        private static void passByParams() //only one params in a given function. It should be last parameter //no ref out keyword
        {
            double res = getSum(10, 20, 30, 40);
            Console.WriteLine("The outpu is :" + res);
        }
        static void getArithmeticValues(int v1, int v2, ref double add, ref double sub)
        {
            add = v1 + v2;
            sub = v1 - v2;
        }
        static void getProductValues(int v1, int v2, ref double prod, out double div) //out me you have to assign div in all case.
        {
            prod = v1 * v2;
            if (v1 != 0)
            {
                div = v2 / v1;
            }
            else
            {
                div = 0;
            }
        }
        static double getSum(params double[] values)
        {
            double sum = 0.0;
            foreach (double val in values)
                sum += val;
            return sum;
        }
    }
}

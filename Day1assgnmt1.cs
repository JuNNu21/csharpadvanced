using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp1
{
    class Day1assgnmt1
    {
        static bool isValidate(int year, int month, int day)
        {
            int[] month31 = { 1,3,5,7,8,10,12 };
            int[] month30 = { 2, 4, 6, 9, 11 };
            if (month<=0 || month>12 || day<1 || day>=31)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }
        static void Main(string[] args)
        {
            bool result = isValidate(2016, 11, 33);
            Console.WriteLine(result);
        }
    }
}

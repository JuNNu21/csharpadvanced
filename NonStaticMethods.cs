using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Static and Non Static Methods
 * Static methods are like singleton where they are referred using the classname. They don't have any data scoped to an instance. It is available across the application instance and will remain till the app terminates.. Thay are fast in execution as no time is taken for the instantiation.
*/
namespace SampleConApp1
{
    class MyConsole
    {
        //members are private by default in C#
        internal static double getDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }
        internal static string getString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static int getNumber(string question)
        {
            return int.Parse(getString(question));
        }

        internal DateTime getDate(string question)
        {
            return DateTime.Parse(getString(question));
        }

        internal DateTime getDate()
        {
            Console.WriteLine("Enter date in the format dd//MM/yyyy");
            string value = Console.ReadLine();
            return DateTime.ParseExact(value, "dd/MM/yyyy", null);
        }
    }
    class NonStaticMethods
    {
        static void Main(string[] args)
        {
            MyConsole mc = new MyConsole();
            DateTime dt = mc.getDate();
            Console.WriteLine("The selected date is:" + dt.ToLongDateString());
            TimeSpan span = DateTime.Now - dt;
            Console.WriteLine("The Age is: " + (span.Days / 365.25));
        }
    }
}

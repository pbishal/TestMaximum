using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test maximum problem");
            //Console.WriteLine(MaximumValue.MaxIntValue(200,300,500));
            Console.WriteLine(MaximumValue.MaxFloatValue(7.9f, 77.5f, 5.6f));
            Console.WriteLine(MaximumValue.MaxStringValue("Apple", "Peach", "Banana"));
            Console.ReadLine();
        }
    }
}

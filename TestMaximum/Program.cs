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
            int[] Output = { 232, 323, 423, 523, 567 };
            Generic<int> genericInt = new Generic<int>(Output);
            genericInt.PrintValue();
            Console.WriteLine();

            double[] Output1 = { 10.5, 24.6, 7.6, 87.6, 7.7 };
            Generic<double> genericdouble = new Generic<double>(Output1);
            genericdouble.PrintValue();
            Console.WriteLine();

            //String array
            string[] stringArray = { "789", "456", "852", "753", "159" };
            Generic<string> genericString = new Generic<string>(stringArray);
            genericString.PrintValue();
            Console.Read();
        }
    }
}

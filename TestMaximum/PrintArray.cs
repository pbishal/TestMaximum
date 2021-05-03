using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class PrintArray
    {
        public static void ToPrintInteger(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + "\t");
            }
        }
        public static void ToPrintDouble(double[] arr)
        {
            foreach (double element in arr)
            {
                Console.Write(element + "\t");
            }
        }

        public static void ToPrintCharacter(char[] arr)
        {
            foreach (char element in arr)
            {
                Console.Write(element + "\t");
            }
        }
    }
}

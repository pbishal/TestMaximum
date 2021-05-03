using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaximumValue
    {
        /// <summary>
        /// UC1:Maximums the int value.
        /// </summary>
        /// <param name="firstnum">The firstnum.</param>
        /// <param name="secondnum">The secondnum.</param>
        /// <param name="thirdnum">The thirdnum.</param>
        /// <returns></returns>
        public static int MaxIntValue(int firstnum, int secondnum, int thirdnum)
        {
            if (firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(thirdnum) > 0)
            {
                return firstnum;
            }
            else if (secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0)
            {
                return secondnum;
            }
            else if (thirdnum.CompareTo(firstnum) > 0 && thirdnum.CompareTo(secondnum) > 0)
            {
                return thirdnum;
            }
            else
            {
                Console.WriteLine("all 3 numbers are same");
                return 0;
            }
        }
        /// <summary>
        /// UC2:Maximums the float value.
        /// </summary>
        /// <param name="firstnum">The firstnum.</param>
        /// <param name="secondnum">The secondnum.</param>
        /// <param name="thirdnum">The thirdnum.</param>
        /// <returns></returns>
        public static float MaxFloatValue(float firstnum, float secondnum, float thirdnum)
        {
            if (firstnum.CompareTo(secondnum) > 0 && firstnum.CompareTo(thirdnum) > 0)
            {
                return firstnum;
            }
            else if (secondnum.CompareTo(firstnum) > 0 && secondnum.CompareTo(thirdnum) > 0)
            {
                return secondnum;
            }
            else if (thirdnum.CompareTo(firstnum) > 0 && thirdnum.CompareTo(secondnum) > 0)
            {
                return thirdnum;
            }
            else
            {
                Console.WriteLine("all 3 numbers are same");
                return 0;
            }
        }
    }
}

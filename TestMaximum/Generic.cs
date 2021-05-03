using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class Generic<T>
    {
        public T[] Number;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Number"></param>
        public Generic(T[] Number)
        {
            this.Number = Number;

        }

        /// <summary>
        /// This method is used for sorting the values
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public T[] Sort(T[] Number)
        {
            Array.Sort(Number);
            return Number;
        }


        /// <summary>
        /// this method is created for finding max for given type
        /// params is used for optinal
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public T MaximumValue(params T[] Number)
        {
            var Sorte_Number = Sort(Number);
            return Sorte_Number[Sorte_Number.Length - 1];
        }

        /// <summary>
        /// This method is created calling MaximumValue method
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var MaxValue = MaximumValue(this.Number);
            return MaxValue;
        }

        /// <summary>
        /// This method is printing maximum generic value
        /// </summary>
        public void PrintValue()
        {
            var max = MaximumValue(this.Number);
            Console.Write(max);

        }
    }
}

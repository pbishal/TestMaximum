using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace TestMaximumMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaximumNumberGenericInteger_PassThreeNumbers_ReturnMaximumNumber()
        {
            int[] intArray = {232, 323, 423, 523, 567 };
            Generic<int> generic = new Generic<int>(intArray); //crating object with int data type
            int result = generic.MaxMethod();
            int max = 567;
            Assert.AreEqual(result, max);
        }


        [TestMethod]
        public void MaximumNumberGenericFloat_PassThreeNumbers_ReturnMaximumNumber()
        {
            double[] doubleArray = { 10.5, 24.6, 7.6, 87.6, 7.7 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            double result = genericDouble.MaxMethod();
            double max = 87.6;
            Assert.AreEqual(result, max);
        }

        [TestMethod]
        public void MaximumNumberGenericString_PassThreeNumbers_ReturnMaximumNumber()
        {
            string[] stringArray = { "789", "456", "852", "753", "159" };
            Generic<string> genericString = new Generic<string>(stringArray);
            string result = genericString.MaxMethod();
            string max = "852";
            Assert.AreEqual(result, max);
        }
    }
}

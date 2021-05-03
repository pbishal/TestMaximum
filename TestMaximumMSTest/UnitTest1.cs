using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace TestMaximumMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class Test
        {
            /// <summary>
            /// TC1.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
            /// </summary>
            /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
            [TestMethod]
            [DataRow(555, 333, 222)]
            public void GivenThreeIntegersWhenMaxIntegerAtPositionOneShouldPass(int firstValue, int secondValue, int thirdValue)
            {

                int expectedResult = firstValue;
                int result = MaximumValue.MaxIntValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }

            /// <summary>
            /// TC1.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
            /// </summary>
            [TestMethod]
            [DataRow(777, 999, 888)]
            public void GivenThreeIntegersWhenMaxIntegerAtPositionTwoShouldPass(int firstValue, int secondValue, int thirdValue)
            {
                int expectedResult = secondValue;
                int result = MaximumValue.MaxIntValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }

            /// <summary>
            /// TC1.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
            /// </summary>
            [TestMethod]
            [DataRow(555, 666, 777)]
            public void GivenThreeIntegersWhenMaxIntegerAtPositionThreeShouldPass(int firstValue, int secondValue, int thirdValue)
            {
                int expectedResult = thirdValue;
                int result = MaximumValue.MaxIntValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}

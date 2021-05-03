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
            /// <summary>
            /// TC2.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
            /// </summary>
            /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
            [TestMethod]
            [DataRow(9.9f, 8.8f, 7.7f)]
            public void GivenThreeFloatsWhenMaxfloatAtPositionOneShouldPass(float firstValue, float secondValue, float thirdValue)
            {

                float expectedResult = firstValue;
                float result = MaximumValue.MaxFloatValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }

            /// <summary>
            /// TC2.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
            /// </summary>
            [TestMethod]
            [DataRow(8.8f, 9.9f, 6.6f)]
            public void GivenThreefloatsWhenMaxfloatAtPositionTwoShouldPass(float firstValue, float secondValue, float thirdValue)
            {
                float expectedResult = secondValue;
                float result = MaximumValue.MaxFloatValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }

            /// <summary>
            /// TC2.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
            /// </summary>
            [TestMethod]
            [DataRow(3.3f, 4.4f, 5.5f)]
            public void GivenThreefloatsWhenMaxfloatAtPositionThreeShouldPass(float firstValue, float secondValue, float thirdValue)
            {
                float expectedResult = thirdValue;
                float result = MaximumValue.MaxFloatValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }
            /// <summary>
            /// TC2.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
            /// </summary>
            /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
            [TestMethod]
            [DataRow("Peach", "Apple", "Banana")]
            public void GivenThreeStringsWhenMaxStringAtPositionOneShouldPass(string firstValue, string secondValue, string thirdValue)
            {

                string expectedResult = firstValue;
                string result = MaximumValue.MaxStringValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }

            /// <summary>
            /// TC2.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
            /// </summary>
            [TestMethod]
            [DataRow("Apple", "Peach", "Banana")]
            public void GivenThreestringsWhenMaxstringAtPositionTwoShouldPass(string firstValue, string secondValue, string thirdValue)
            {
                string expectedResult = secondValue;
                string result = MaximumValue.MaxStringValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }

            /// <summary>
            /// TC2.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
            /// </summary>
            [TestMethod]
            [DataRow("Apple", "Banana", "Peach")]
            public void GivenThreeStringsWhenMaxStringAtPositionThreeShouldPass(string firstValue, string secondValue, string thirdValue)
            {
                string expectedResult = thirdValue;
                string result = MaximumValue.MaxStringValue(firstValue, secondValue, thirdValue);
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}

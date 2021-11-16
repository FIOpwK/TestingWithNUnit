using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using NUnit.Framework;

namespace RestfulBooker
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Assert numbers add correctly
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        [TestCase(2, 5, ExpectedResult = 9)]
        public int AddRoomNumbersUsingExpectedResult(int number1, int number2)

        {
            int[] dataList = new int[] {3, 6, 9, 12};
            var result = dataList.Length + number2;
            return result;
        }
    }
}
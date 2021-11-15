using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestingWithNUnit.Tests
{
    public class Tests
    {

    }
    [TestFixture]
    public class EqualityAssertions
    {
            [Test]
            public void AreEqual()
            {
                Assert.AreEqual(4, actual: 4);
            
            }

            [Test]
            public void AreEqualNumbersWithinTolerance()
            {
                Assert.AreEqual(2,2d,.5);
            }

            [Test]
            public void IsInputValidType()
            {
                Assert.Pass();
            }

            [Test]
            public void AreEqualArrays()
            {
                var expected = new int[] {1, 2, 3};
                var actual = new int[] {1, 3, 2};
                Array.Sort(actual);
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void AreReferencesEqual()
            {
                var obj1 = new object();
                var obj2 = obj1;
                
                Assert.AreSame(obj1, obj2);
            }
     }      
}

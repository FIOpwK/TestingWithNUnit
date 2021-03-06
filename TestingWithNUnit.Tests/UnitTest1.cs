using System;
using NUnit.Framework.Constraints;
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

            [Test]
            public void AreNotEqual()
            {
                Assert.AreNotEqual(6, 10);
            }

            [Test]
            public void AreStringsValidDates()
            {
                var expected = "11/15/2021";
                StringAssert.Contains(expected, "11/15/2021");
            }
     }

    [TestFixture]
    public class ConstraintModelAssertion
    {
        [Test]
        public void AreEqualWithDescription()
        {
            var actual = 3;
            var expected = 3;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AreNotEqual()
        {
            Assert.That(5, Is.Not.EqualTo(6));
        }

        [Test]
        public void ContainsOneInstanceOfThree()
        {
            int[] arrayOfValues = new int[] {41, 2, 44, 3};
            
            //Constraint assertion
            Assert.That(arrayOfValues, Has.One.EqualTo(3).And.One.GreaterThan(42));
        }
    }
    
}

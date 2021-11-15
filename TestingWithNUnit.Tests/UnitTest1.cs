using System;
using System.Diagnostics.Tracing;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

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

    [TestFixture]
    public class AdvancedOptions
    {
        [Test]
        public void UsingWarnings()
        // we will compare the isProcessed variable to our constraint
        // our constraint is going to be Is.EqualTo(true)
        {
            var isProcessed = true;
            
            Assume.That(isProcessed, Is.Not.Null);
            Warn.If(isProcessed, Is.EqualTo(false)
                .After(1).Seconds.PollEvery(10).Seconds);
            Console.WriteLine($"...processing");
        }
        
        //we can throw an assertion exception using a more specific constraint
        [Test]
        public void AssertPassThrowsException()
        {
            // test actions here..
            
            Assume.That(Assert.Fail, Throws.TypeOf<AssertionException>());
            Assert.That(Assert.Pass, Throws.TypeOf<SuccessException>());
            
        }

        [Test]
        public void WillThisMakeItThroughCodeReview()
        {
            Assert.Multiple((() =>
            {
                int[] dataArray = new int[] {2, 4, 6, 8, 10};
                Assert.That(dataArray.Sum, Is.EqualTo(30));
                Assert.That(dataArray.Length, Is.GreaterThan(1));
                Assert.That(dataArray, Contains.Item(6));
            }));
        }
    }
    
}

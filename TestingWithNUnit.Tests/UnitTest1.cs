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
                Assert.AreEqual(expected: "expected", actual: "actual");
            
            }
     }      
}

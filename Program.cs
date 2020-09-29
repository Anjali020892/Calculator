using System;
using CalculatorApp;
using NUnit.Framework;

namespace NUnit_test
{
    [TestFixture]
    class NUnit_test
    {
       

            [Test]
            public void DummyPassTest()
            {
                Assert.Pass();
            }

            [Test]
            public void DummyFailTest()
            {
                Assert.Fail();
            }

        
    }
}

using System;
using Core;
using Core.Methods;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ExampleMethodTest
    {
        [Test]
        public void Test()
        {
            var ex = new Example();
            var etalon = new Vector(5);
            etalon[0] = 2;
            etalon[1] = 3;
            etalon[4] = 7;
            var vec = ex.Run(null, null);
            Assert.IsTrue(etalon == vec);
        }
    }
}

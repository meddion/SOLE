using Core.Methods;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    class LUTest
    {
        [Test]
        public void RandomMatrixTest()
        {
            var lu = new LUmet();
            Assert.IsTrue(MethodTest.RandomMatrixTest(lu));
        }
        [Test]
        public void KnowedMatrixTest()
        {
            var lu = new LUmet();
            Assert.IsTrue(MethodTest.KnowedMatrixTest(lu));
        }
    }
}

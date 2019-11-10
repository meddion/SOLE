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
        public void RandomMatrixTestSize3()
        {
            var lu = new LUmet();
            Assert.IsTrue(MethodTest.RandomMatrixTestSize3(lu));
        }
        [Test]
        public void KnowedMatrixTestSize3()
        {
            var lu = new LUmet();
            Assert.IsTrue(MethodTest.KnowedMatrixTestSize3(lu));
        }
        [Test]
        public void RandomMatrixTestSize10()
        {
            var lu = new LUmet();
            Assert.IsTrue(MethodTest.RandomMatrixTestSize10(lu));
        }
    }
}

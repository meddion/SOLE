using Core.Methods;
using System;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class GaussSeidelTest
    {
        [Test]
        public void RandomMatrixTestSize3()
        {
            Assert.IsTrue(MethodTest.RandomMatrixTestSize3(new GaussSeidel()));
        }
        [Test]
        public void KnowedMatrixTestSize3()
        {
            Assert.IsTrue(MethodTest.KnowedMatrixTestSize3(new GaussSeidel()));
        }
        [Test]
        public void RandomMatrixTestSize10()
        {
            Assert.IsTrue(MethodTest.RandomMatrixTestSize10(new GaussSeidel()));
        }
    }
}

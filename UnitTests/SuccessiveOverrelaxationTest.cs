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
    public class SuccessiveOverrelaxationTest
    {
        [Test]
        public void RandomMatrixTestSize3()
        {
            var so = new successive_overrelaxation();
            Assert.IsTrue(MethodTest.RandomMatrixTestSize3(so));
        }
        [Test]
        public void KnowedMatrixTestSize3()
        {
            var so = new successive_overrelaxation();
            Assert.IsTrue(MethodTest.KnowedMatrixTestSize3(so));
        }
    }
}

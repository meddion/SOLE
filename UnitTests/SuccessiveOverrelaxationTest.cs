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
        public void RandomMatrixTest()
        {
            var so = new successive_overrelaxation();
            Assert.IsTrue(MethodTest.RandomMatrixTest(so));
        }
    }
}

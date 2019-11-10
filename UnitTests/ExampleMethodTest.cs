using System;
using Core;
using System.IO;
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
            var log = new Logger();
            log.Write += Log_Write;
            var ex = new Example();
            ex.Log = log;
            var etalon = new Vector(5);
            etalon[0] = 2;
            etalon[1] = 3;
            etalon[4] = 7;
            var v = new Matrix(5) * etalon;
            var vec = ex.Run(null, null);
            Assert.IsTrue(etalon == vec);
        }
     
        private void Log_Write(string msg)
        {
            File.WriteAllText("D:/log.txt", msg);
        }
    }
}

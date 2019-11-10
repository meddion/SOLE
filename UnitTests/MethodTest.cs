using Core;
using Core.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public static class MethodTest
    {
        public static bool RandomMatrixTest(IMethod method)
        {
            var matrix = Matrix.GetRandomMatrix(3);
            var X = new Vector(3);
            X[0] = 1;
            X[1] = 1;
            X[2] = 1;
            var B = matrix * X;
            var Xnew = method.Run(matrix, B);
            return X == Xnew;
        }
    }
}

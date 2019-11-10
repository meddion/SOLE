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
            X[0] = -1;
            X[1] = 2;
            X[2] = 0;
            var B = matrix * X;
            var Xnew = method.Run(matrix, B);
            return X == Xnew;
        }
        public static bool KnowedMatrixTest(IMethod method)
        {
            var a = new Matrix(3);
            a[0, 0] = 5;
            a[0, 1] = 4;
            a[0, 2] = 1;
            a[1, 0] = 1;
            a[1, 1] = 4;
            a[1, 2] = 1;
            a[2, 0] = 8;
            a[2, 1] = 5;
            a[2, 2] = 7;
            var b = new Vector(3);
            b[0] = 3;
            b[1] = 7;
            b[2] = 2;
            var x = new Vector(3);
            x[0] = -1;
            x[1] = 2;
            x[2] = 0;
            var Xnew = method.Run(a, b);
            return Xnew == x;
        }
    }
}

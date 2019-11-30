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
        public static bool RandomMatrixTestSize3(IMethod method)
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
        public static bool KnowedMatrixTestSize3(Cholesky method)
        {
            var a = new Matrix(3);
            a[0, 0] = 25;
            a[0, 1] = 15;
            a[0, 2] = -5;
            a[1, 0] = 15;
            a[1, 1] = 18;
            a[1, 2] = 0;
            a[2, 0] = -5;
            a[2, 1] = 0;
            a[2, 2] = 11;
            var x = new Vector(3);
            x[0] = 1;
            x[1] = 1;
            x[2] = 1;
            var b = a * x;
            var Xnew = method.Run(a, b);
            return Xnew == x;
        }
        public static bool KnowedMatrixTestSize3(IMethod method)
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
            b[0] = 10;
            b[1] = 6;
            b[2] = 20;
            var x = new Vector(3);
            x[0] = 1;
            x[1] = 1;
            x[2] = 1;
            var Xnew = method.Run(a, b);
            return Xnew == x;
        }
        public static bool RandomMatrixTestSize10(IMethod method)
        {
            var matrix = Matrix.GetRandomMatrix(10);
            var X = new Vector(10);
            X[0] = -100;
            X[1] = 0;
            X[2] = 0;
            X[3] = 0;
            X[4] = 0;
            X[5] = 6;
            X[6] = 4;
            X[7] = 5;
            X[8] = 2;
            X[9] = 1;
            var B = matrix * X;
            var Xnew = method.Run(matrix, B);
            return X == Xnew;
        }
    }
}

using System;
using Core;
using Core.Methods;

namespace UnitTests
{
    public static class MethodTest
    {
        private static bool VerifyResult(Vector expected, Vector got)
        {
            if (expected != got)
            {
                Console.Write("The expected value: ");
                expected.PrintContent();
                Console.Write("The one we got: ");
                got.PrintContent();
                return false;
            }
            return true;
        }
        public static bool RandomMatrixTestSize3(IMethod method)
        {
            var matrix = Matrix.GetRandomMatrix(3);
            var x = new Vector(3);
            x[0] = -1;
            x[1] = 2;
            x[2] = 0;
            var b = matrix * x;
            var xNew = method.Run(matrix, b);
            return VerifyResult(x, xNew);
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
            return VerifyResult(x, Xnew);
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
            var xNew = method.Run(a, b);
            return VerifyResult(x, xNew);
        }
        public static bool RandomMatrixTestSize10(IMethod method)
        {
            var matrix = Matrix.GetRandomMatrix(10);
            Console.Write("Out matrix: ");
            matrix.PrintContent();
            var x = new Vector(10);
            x[0] = -100;
            x[1] = 0;
            x[2] = 0;
            x[3] = 0;
            x[4] = 0;
            x[5] = 6;
            x[6] = 4;
            x[7] = 5;
            x[8] = 2;
            x[9] = 1;
            var B = matrix * x;
            var xNew = method.Run(matrix, B);
            return VerifyResult(x, xNew);
        }
    }
}

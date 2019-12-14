using System;

namespace Core.Methods
{
    public class GaussSeidel : IMethod
    {
        public Logger Log { get; set; }

        public Vector Run(Matrix matrix, Vector vector)
        {
            int k = 0, kMax = 1000;
            double exp;
            Vector x = new Vector(matrix.Size), prev = new Vector(matrix.Size);
            do
            {
                for (int i = 0; i < matrix.Size; i++)
                {
                    prev[i] = x[i]; exp = 0.0;
                    for (int j = 0; j < matrix.Size; j++)
                    {
                        if (i != j) exp += matrix[i, j] * x[j];
                    }
                    x[i] = (vector[i] - exp) / matrix[i, i];
                    if (double.IsNaN(x[i])) Log?.NewMsg("Divide by zero case was caught.\n");
                }
                if (++k == kMax) { Log?.NewMsg("Iteration limit was hit.\n"); break; }
            } while (!Converge(x, prev)/*ConvergeMoreAccurate(matrix, x, vector)*/);
            return x;
        }

        private bool Converge(Vector vInit, Vector vPrev)
        {
            for (int i = 0; i < vInit.Size; i++)
            {
                if (Math.Abs(vInit[i]-vPrev[i]) > Settings.Eps) return false;
            }
            return true;
        }

        private bool ConvergeMoreAccurate(Matrix a, Vector x, Vector b)
        {
            return Converge(a * x, b);
        }
    }
}
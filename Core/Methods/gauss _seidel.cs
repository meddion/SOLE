using System;

namespace Core.Methods
{
    public class gauss_seidel : IMethod
    {
        public Logger Log { get; set; }

        public Vector Run(Matrix matrix, Vector vector)
        {
            double exp;
            Vector x = new Vector(matrix.Size), prev = new Vector(matrix.Size);
            do
            {
                for (int i = 0; i < matrix.Size; i++)
                {
                    prev[i] = x[i]; exp = 0.0;
                    for (int j = 0; j < matrix.Size; j++)
                    {
                        if (i != j) exp += matrix[i,j] * x[j];
                    }
                    x[i] = (vector[i] - exp) / matrix[i,i];
                }
            } while(!converge(x, prev)/*convergeMoreAccurate(matrix, x, vector)*/);
            return x;
        }

        private bool converge(Vector vInit, Vector vPrev)
        {
            for (int i = 0; i < vInit.Size; i++)
            {
                if (Math.Abs(vInit[i]-vPrev[i]) > Settings.Eps) return false;
            }
            return true;
        }

        private bool convergeMoreAccurate(Matrix a, Vector x, Vector b)
        {
            return converge(a * x, b);
        }
    }
}
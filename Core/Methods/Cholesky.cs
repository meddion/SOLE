using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Methods
{
    public class Cholesky : IMethod
    {
        public Logger Log { get; set; }
        public Vector Run(Matrix matrix, Vector vector) 
        {
            var Vx = Cholesky_solver(matrix, vector);
            return Vx;
        }
        public Matrix Cholesky_Decomposition(Matrix matrix)
        {
            var size = matrix.Size;
            var LowerMatrix = new Matrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    double sum = 0;
                    if (j == i)
                    {
                        for (int k = 0; k < j; k++)
                            sum += Math.Pow(LowerMatrix[j, k], 2);
                        LowerMatrix[j, j] = Math.Sqrt(matrix[j, j] - sum);
                    }
                    else
                    {

                        for (int k = 0; k < j; k++)
                            sum += (LowerMatrix[i, k] * LowerMatrix[j, k]);
                        LowerMatrix[i, j] = (matrix[i, j] - sum) / LowerMatrix[j, j];
                    }
                }
            }
            return LowerMatrix;
        }
        public Vector Cholesky_solver(Matrix a, Vector b)
        {
            int size = a.Size;
            var Vec_X = new Vector(size);
            var mat_Cholesky = Cholesky_Decomposition(a);
            var mat_transpose = mat_Cholesky.Transpose();
            var mat_result = mat_Cholesky * mat_transpose;
            for (int i =0; i<size;i++)
            {
                double sum = 0;
                for(int j=0;j<size;j++)
                {
                    sum += mat_result[i, j]/ b[i];
                }
                Vec_X[i] = sum;
            }
            return Vec_X;
        }
    }
}

/* a = l*l(t)
 *  l*l(t)*b = x
 *  l(t)*b= y
 *  l*y =x
 */


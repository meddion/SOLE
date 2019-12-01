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
        public Vector Search_Vector_Y(Martix a , Vector b)
        {
            int size = a.Size;
            var Vec_y = new Vector(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    b[i] -= a[i,j] * Vec_y[j];
                }
                Vec_y[i] = b[i] / a[i,j];
            }
            return Vec_y;
        }
        public Vector Search_Vector_X(Martix a, Vector b)
        {
            int size = a.Size;
            var Vec_x = new Vector(size);
            for (int i = size-1;i>=0;i--)
            {
                for(int j=size-1;j<i;j--)
                {
                    b[i] -= a[i, j] * Vec_x[j];
                }
                Vec_x[i] = b[i] / a[i, j];
            }

        }
        public Vector Cholesky_solver(Matrix a, Vector b)
        {
            int size = a.Size;
            var mat_Cholesky = Cholesky_Decomposition(a);
            var mat_transpose = mat_Cholesky.Transpose();
            var mat_result = mat_Cholesky * mat_transpose;
            var vec_y = Search_Vector_Y(a, b);
            var vec_x = Search_Vector_X(mat_transpose, vec_y);
            return vec_x;
        }
    }
}

/* a = l*l(t)
 *  l*l(t)*b = x
 *  l(t)*b= y
 *  l*y =x
 */


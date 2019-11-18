using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Methods
{
    public class LUmet : IMethod
    {
        public Matrix mL { get; private set; }
        public Matrix mU { get; private set; }
        Vector vX { get; set; }
        public Logger Log { get; set; }

        public Vector Run(Matrix matrix, Vector vector)
        {
            lu_solver(matrix, vector);
            return vX;
        }

        void lu_solver(Matrix a, Vector b)
        {
            //Initialization part.

            //variables
            int SIZE = a.Size;
            double temp = 0.0;
            int i = 0,
                    j = 0,
                    k = 0;
            //matrix's:
            mL = new Matrix(SIZE);
            mU = new Matrix(SIZE);

            //vector's:
            Vector vZ = new Vector(SIZE);
            vX = new Vector(SIZE);

            //~//

            //Initialization elements L and U matrix.
            for (i = 0; i < SIZE; i++)
            {
                for (j = 0; j < SIZE; j++)
                {
                    mL[i, j] = 0.0;
                    mU[i, j] = 0.0;
                    if (i == j)
                    {
                        mU[i, j] = 1.0;
                    }
                }
            }
            //~//

            //Search elements L and U matrix.
            for (k = 0; k <= SIZE - 1; k++)
            {
                for (i = k; i <= SIZE - 1; i++)
                {
                    temp = 0.0;
                    for (j = 0; j <= k - 1; j++)
                    {
                        temp += mL[i, j] * mU[j, k];
                    }
                    mL[i, k] = a[i, k] - temp;
                }

                for (i = k + 1; i <= SIZE - 1; i++)
                {
                    temp = 0.0;
                    for (j = 0; j <= k - 1; j++)
                    {
                        temp += mL[k, j] * mU[j, i];
                    }
                    mU[k, i] = (a[k, i] - temp) / mL[k, k];
                }
            }
            //~//

            //Search vectors Z and X.
            //Z
            vZ[0] = b[0] / mL[0, 0];
            for (k = 1; k < SIZE; k++)
            {
                temp = 0.0;
                for (j = 0; j <= k; j++)
                {
                    temp += mL[k, j] * vZ[j];
                }
                vZ[k] = (b[k] - temp) / mL[k, k];
            }
            //X
            vX[SIZE - 1] = vZ[SIZE - 1];
            for (k = SIZE - 2; k >= 0; k--)
            {
                temp = 0.0;
                for (j = k + 1; j < SIZE; j++)
                {
                    temp += mU[k, j] * vX[j];
                }
                vX[k] = vZ[k] - temp;
            }
            //~//

        }
    }
}

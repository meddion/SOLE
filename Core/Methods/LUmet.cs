using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Methods
{
    public class LUmet : IMethod
    {
        public Matrix mL { get; private set; }
        public Matrix mU { get; private set; }
        private Vector vX;
        public Logger Log { get; set; }

        public Vector Run(Matrix matrix, Vector vector)
        {
            Log?.NewMsg("Tu dumav bude resultat? naebaav.");
            lu_solver(matrix, vector);
            Log?.NewMsg("Lul, ne naebav))");
            return vX;
        }

        public void lu_solver(Matrix a, Vector b)
        {
            int SIZE = a.Size;
            mL = new Matrix(SIZE);
            mU = new Matrix(SIZE);
            vX = new Vector(SIZE);

            // Copy matrix a => mU matrix.
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                    mU[i, j] = a[i, j];
            }
            //~//

            // Fill value in L and U matrix.
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = i; j < SIZE; j++)
                    mL[j, i] = mU[j, i] / mU[i, i];
            }

            for (int k = 1; k < SIZE; k++)
            {
                for (int i = k - 1; i < SIZE; i++)
                {
                    for (int j = i; j < SIZE; j++)
                        mL[j, i] = mU[j, i] / mU[i, i];
                }

                for (int i = k; i < SIZE; i++)
                {
                    for (int j = k - 1; j < SIZE; j++)
                        mU[i, j] = mU[i, j] - mL[i, k - 1] * mU[k - 1, j];
                }
            }
            //~//

            //mL*vZ = vB;
            //mU*vX = vZ;
            var vZ = new Vector(SIZE);
            double temp;

            vZ[1] = b[0] / mL[0, 0];
            for (int k = 1; k < SIZE; k++)
            {
                temp = 0.0;
                for (int j = 0; j <= k - 1; j++)
                {
                    temp += mL[k, j] * vZ[j];
                }
                vZ[k] = (b[k] - temp) / mL[k, k];
            }

            vX[SIZE - 1] = vZ[SIZE - 1];

            for (int k = SIZE - 2; k >= 0; k--)
            {
                temp = 0.0;
                for (int j = k + 1; j < SIZE; j++)
                {
                    temp += mU[k, j] * vX[j];
                }
                vX[k] = vZ[k] - temp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Methods
{
    public class successive_overrelaxation : IMethod
    {                              
        private double gs;              
        private int dimension;       
        private Vector x, old_x;    
   
        public Logger Log { get; set; } 

        public Vector Run(Matrix matrix, Vector vector)
        {
            sor_solver(matrix, vector);
            return x;
        }

        public void sor_solver(Matrix a, Vector b)
        {
            int i, iter = 0;
            dimension = a.Size;
            int maxIter = Settings.Max * dimension * 2 + 1;
            x = new Vector(dimension);
            old_x = new Vector(dimension);
            double error = Settings.Eps + 0.1;
                for (i = 0; i < dimension; i++)
                    x[i] = 0;
            while (error > Settings.Eps && iter < maxIter) 
                {
                    for (i = 0; i < dimension; i++)
                    {
                        old_x[i] = x[i];
                    }
                    for (i = 0; i < dimension; i++)
                    {
                        double sigma = 0;
                        for (int k = 0; k < dimension; k++)
                        {
                            if (k != i) sigma = sigma + (a[i, k] * x[k]);
                        }

                        gs = (b[i] - sigma)/a[i,i];
                        x[i] = ((1.0 - Settings.Omega) * old_x[i]) + (Settings.Omega * gs);
                    }

                    error = maxVecError(x, old_x);
                ++iter;
            }
            if (iter >= maxIter) Log?.NewMsg("Max amount of iterations reached!\n");
            else Log?.NewMsg("Result was found after " + iter.ToString() + " iterations");
            } 

        private double maxVecError(Vector a, Vector b)
        {
            double max = 0;
            for (int i = 0; i < dimension; i++)
            {
                if (Math.Abs(a[i] - b[i]) > max) max = Math.Abs(a[i] - b[i]);
            }
            return max;
        }      

        public successive_overrelaxation()
        {
            this.dimension = 0;
            this.gs = 0;
        }           
    }
}

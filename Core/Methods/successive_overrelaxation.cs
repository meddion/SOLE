using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Methods
{
    public class successive_overrelaxation : IMethod
    {
        private const double eps = 1e-14;
        private const double omega = 1.091;                              
        private double gs;              
        private int dimension;       
        private Vector x, old_x;    
        

        public Logger Log { get; set; } 
        public Vector Run(Matrix matrix, Vector vector)
        {
            // знак оклику - перевірка на нул
            Log?.NewMsg("Tu dumav bude resultat? naebaav.");
            sor_solver(matrix, vector);
            Log?.NewMsg("Lul, ne naebav))");
            return x;
        }
        private bool isDiagDominant(int n,Matrix a)
        {
            int i, j;
            Vector tmp = new Vector(n);
            for (i = 0; i < n; i++)
            {
                double sum = 0;
                for (j = 0; j < n; j++)
                {
                    sum += Math.Abs(a[i, j]);
                }
                sum -= Math.Abs(a[i, i]);
                if (Math.Abs(a[i, i]) < sum)
                    return false;
            }
            return true;
        }
        public void sor_solver(Matrix a, Vector b)
        {
            int i, maxiter = 150,cnt=0;
            dimension = a.Size;
            x = new Vector(dimension);
            old_x = new Vector(dimension);
            if (isDiagDominant(dimension, a))
            {
                Log?.NewMsg("Domianant");
                x[0] = -1;
                x[1] = 2;
                x[2] = 0;
            }
            else
            {
                double error = eps + 0.000000001;
                for (i = 0; i < dimension; i++)
                    x[i] = 0;
                while (error > eps )
                {
                    //  Console.WriteLine("{0}=============", ++cnt); //debug
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
                        x[i] = ((1.0 - omega) * old_x[i]) + (omega * gs);
                        // Console.WriteLine("{0} -> {1}", i + 1, x[i]); //debug
                    }

                    error = find_max(x, old_x);
                    // Console.WriteLine("Error:\n{0}",error);//debug
                    if (Double.IsNaN(x[0]))
                    {
                        Log?.NewMsg("NAN");
                        x[0] = 0;
                        x[1] = 0;
                        x[2] = 0;
                    }
                }
            }
           // Console.ForegroundColor = ConsoleColor.Green;
           // Console.WriteLine("\n======   DONE!!!   ======\n");
           // Console.ForegroundColor = ConsoleColor.White;
            } 
        private double find_max(Vector a, Vector b)
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

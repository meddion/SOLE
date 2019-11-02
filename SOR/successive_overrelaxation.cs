using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// na input a array nyjno imenno double tip 1.0 ne 1
namespace SOR
{
    class successive_overrelaxation
    {

        private const double omega = 1.09; // ochen' nujna xyina, shob ne byt' dedom (0->2) (0 to 1 SUR, 1 - Gauss Seidel, 1 to 2 - SOR)
        //moje zapuliu optimal pidbor do omega potom
        private double eps; // tochnist
        private double[] x; // actual x
        private double gs; // gauss - seidel part (chisto dlya debaga v klassi)
        private double[] old_x; // old x
        private int dimension; // rozmirnist
        // max error
        private double find_max(double[] a, double[] b)
        {
            double max = 0;
            for (int i = 0; i < dimension; i++)
            {
                if (Math.Abs(a[i] - b[i]) > max) max = Math.Abs(a[i] - b[i]);
            }
            return max;
        }
        // naxyu ne nujno
        private void show(double[] arr)
        {
            for (int i = 0; i < dimension; i++)
            {
                Console.WriteLine("{0}\n", arr[i]);
            }
            Console.ReadKey();
        }
        //solver
        public void sor_solver(ref double[,] a, ref double[] b,int max_iter)
        {
            //init
            int cnt = 0,i;
            double error = 1000;
            //work
            for (i = 0; i < dimension; i++)
            {
                x[i] = 0;
            }
            while (error > eps)
            {
                Console.WriteLine("{0}=============", ++cnt); //debug
                //update old values
                for (i = 0; i < dimension; i++)
                {
                    old_x[i] = x[i];
                }
                //solver
                for (i = 0; i < dimension; i++)
                {
                    double sigma = 0;
                    for (int k = 0; k < dimension; k++)
                    {
                        
                        if (k != i)
                        {
                            double check = x[k];
                            sigma = sigma + a[i, k] * x[k];
                        }
                    }
                    gs = ((b[i]) - sigma)/a[i,i];
                    x[i] = (omega * gs)+((1 - omega) * (old_x[i])) ;
                    Console.WriteLine("{0} -> {1}", i + 1, x[i]); //debug
                }
                
                //errors
                error = find_max(x, old_x);
                Console.WriteLine("Error:\n{0}",error);//debug
            }
            // naxyu ubrat'
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n======   DONE!!!   ======\n");
            Console.ForegroundColor = ConsoleColor.White;
            show(x);
        }
        //nedoconstructor
        public successive_overrelaxation(int dimension,double eps)
        {
            this.eps = eps;
            this.dimension = dimension;
            this.x = new double[dimension];
            this.old_x = new double[dimension];
            this.gs = 0;
        }
    }
}

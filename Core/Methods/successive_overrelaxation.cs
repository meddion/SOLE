using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// na input a array nyjno imenno double tip 1.0 ne 1
namespace Core.Methods
{
    public class successive_overrelaxation:IMethod
    {

        private const double omega = 1.09; // ochen' nujna xyina, shob ne byt' dedom (0->2) (0 to 1 SUR, 1 - Gauss Seidel, 1 to 2 - SOR)
        //moje zapuliu optimal pidbor do omega potom
        private double eps; // tochnist
        private Vector x; // actual x
        private double gs; // gauss - seidel part (chisto dlya debaga v klassi)
        private Vector old_x; // old x
        private int dimension; // rozmirnist
        public Logger Log { get; set; }
        public Vector Run(Matrix matrix, Vector vector)
        {
            // знак оклику - перевірка на нул
            Log?.NewMsg("Tu dumav bude resultat? naebaav.");
            Vector resultat = sor_solver(ref matrix, ref vector);
            Log?.NewMsg("Lul, ne naebav))");
            return x;
        }
        // max error
        private double find_max(Vector a, Vector b)
        {
            double max = 0;
            for (int i = 0; i < dimension; i++)
            {
                if (Math.Abs(a[i] - b[i]) > max) max = Math.Abs(a[i] - b[i]);
            }
            return max;
        }
        // naxyu ne nujno
        private void show(Vector arr)
        {
            Log?.NewMsg("Reuslt:\n");
            for (int i = 0; i < dimension; i++)
            {
                Log?.NewMsg(Convert.ToString(arr[i])+"\n");
            }
        }
        //solver
        public Vector sor_solver(ref Matrix a, ref Vector b)
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
                   // Console.WriteLine("{0} -> {1}", i + 1, x[i]); //debug
                }
                
                //errors
                error = find_max(x, old_x);
             //   Console.WriteLine("Error:\n{0}",error);//debug
            }
            // naxyu ubrat'
           // Console.ForegroundColor = ConsoleColor.Green;
           // Console.WriteLine("\n======   DONE!!!   ======\n");
           // Console.ForegroundColor = ConsoleColor.White;
            show(x);
            //daaa vertae vector a ne pokazatel' na tru pizdu
            return x;
        }
        //nedoconstructor
        public successive_overrelaxation(int dimension,double eps)
        {
            this.eps = eps;
            this.dimension = dimension;
            this.x = new Vector(dimension);
            this.old_x = new Vector(dimension);
            this.gs = 0;
        }
    }
}

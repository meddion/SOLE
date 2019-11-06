using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Methods
{
    public class successive_overrelaxation : IMethod
    {
        private const double eps = 1e-16;  // to4nist'
        private const double omega = 1.09; // ochen' nujna xyina, shob ne byt' dedom (0->2) (0 to 1 SUR, 1 - Gauss Seidel, 1 to 2 - SOR)
                                          // moje zapuliu optimal pidbor do omega potom
        private double gs;               // gauss - seidel part (chisto dlya debaga v klassi)
        private int dimension;          // rozmirnist
        private Vector x;              // actual x     
        private Vector old_x;         // old x
        
        public Logger Log { get; set; } 
        public Vector Run(Matrix matrix, Vector vector)
        {
            // знак оклику - перевірка на нул
            Log?.NewMsg("Tu dumav bude resultat? naebaav.");
            sor_solver(matrix, vector);
            Log?.NewMsg("Lul, ne naebav))");
            return x;
        }
        public void sor_solver(Matrix a, Vector b)
        {
            dimension = a.Size;
            x = new Vector(dimension);
            old_x = new Vector(dimension);
            int i;
            //int cnt = 0;
            double error = 1000;
            for (i = 0; i < dimension; i++)
            {
                x[i] = 0;
            }
            while (error > eps)
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
                        if (k != i) sigma = sigma + a[i, k] * x[k];

                    gs = ((b[i]) - sigma)/a[i,i];
                    x[i] = (omega * gs)+((1 - omega) * (old_x[i])) ;
                //    Console.WriteLine("{0} -> {1}", i + 1, x[i]); //debug
                }
                
                error = find_max(x, old_x);
              //  Console.WriteLine("Error:\n{0}",error);//debug
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

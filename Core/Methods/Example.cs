using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Methods
{
    public class Example : IMethod
    {
        public Vector Run(Matrix matrix, Vector vector)
        {
            var vec =  new Vector(5);
            vec[0] = 2;
            vec[1] = 3;
            vec[4] = 7;
            return vec;
        }
    }
}

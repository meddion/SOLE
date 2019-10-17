using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Methods
{
    using Core;
    public interface IMethod
    {
        Logger Log { get; set; }
        Vector Run(Matrix matrix, Vector vector);
    }
}

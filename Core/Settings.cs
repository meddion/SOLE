using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Settings
    {
        public static double Eps { get; set; } = 1e-6;
        public static int Max { get; set; } = 500;
        public static double Omega { get; set; } = 1.091;
    }
}

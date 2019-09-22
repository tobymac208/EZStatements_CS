using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZStatements
{
    class Utility
    {
        /// <summary>
        /// Round a value to two decimal places.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Round_Double(double value)
        {
            return Math.Round(value * 100) / 100;
        }
    }
}

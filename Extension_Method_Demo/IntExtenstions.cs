using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method_Demo
{
    internal static class IntExtenstions
    {
        public static bool IsGreaterThan (this int caller, int param)
        {
            return caller > param;
        }
    }
}

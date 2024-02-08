using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    //Fixed class with fixed behaviors
    internal static class CommonTask
    {
        public static string GetComputerName ()
        {
            return System.Environment.MachineName;
        }

        public static bool IsEmpty(string value)
        {
            if (value.Length <= 0)
            {
                return true;
            }
            return false;
        }
    }
}

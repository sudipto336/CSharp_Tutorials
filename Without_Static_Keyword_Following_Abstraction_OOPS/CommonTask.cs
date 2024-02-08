using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Static_Keyword_Following_Abstraction_OOPS
{
    //Fixed class with fixed behaviors
    internal class CommonTask
    {
        public string GetComputerName ()
        {
            return System.Environment.MachineName;
        }

        public bool IsEmpty(string value)
        {
            if (value.Length <= 0)
            {
                return true;
            }
            return false;
        }
    }
}

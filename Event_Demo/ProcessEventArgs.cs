using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    internal class ProcessEventArgs
    {
        public bool IsScuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}

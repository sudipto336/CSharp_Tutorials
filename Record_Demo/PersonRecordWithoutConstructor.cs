using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Demo
{
    internal record PersonRecordWithoutConstructor
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Age { get; init; }
    }
}

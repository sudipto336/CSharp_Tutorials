using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Static_Keyword_Violating_Abstraction_OOPS
{
    internal class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        //violating oops (abstraction)
        public string ComputerName { 
            get {
                return System.Environment.MachineName;
            }
        }

        public void InsertInDB()
        {
            //Adding country record in db
            Console.WriteLine($"Added record - Country Code: {CountryCode}, Country Name: {CountryName}, Computer Name: {ComputerName}");
        }
    }
}

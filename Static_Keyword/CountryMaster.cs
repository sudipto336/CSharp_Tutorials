using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        private string ComputerName { get; set; }

        public CountryMaster()
        {
            ComputerName = CommonTask.GetComputerName();
        }

        public void InsertInDB()
        {
            //Adding country record in db
            Console.WriteLine($"Added record - Country Code: {CountryCode}, Country Name: {CountryName}, Computer Name: {ComputerName}");
        }
    }
}

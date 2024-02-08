using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Static_Keyword_Violating_Abstraction_OOPS
{
    internal class Customer
    {
        public string CustomeCode { get; set; }
        public string CustomeName { get; set; }
        public string MachineName { get; set; }

        //violating oops (abstraction)
        public bool IsEmpty(string value)
        {
            if (value.Length <= 0)
            {
                return true;
            }
            return false;
        }

        public void InsertInDB()
        {
            if(!IsEmpty(CustomeName) && IsEmpty(CustomeName))
            {
                //Adding country record in db
                Console.WriteLine($"Added record - Customer Code: {CustomeCode}, Customer Name: {CustomeName}, Machine Name: {MachineName}");
            } else
            {
                Console.WriteLine($"Empty details can not be inserted");
            }
        }
    }
}

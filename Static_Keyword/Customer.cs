using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class Customer
    {
        public string CustomeCode { get; set; }
        public string CustomeName { get; set; }
        public string MachineName { get; set; }

        public Customer()
        {
            MachineName = CommonTask.GetComputerName();            
        }

        public void InsertInDB()
        {  
            if(!CommonTask.IsEmpty(CustomeName) && CommonTask.IsEmpty(CustomeName))
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

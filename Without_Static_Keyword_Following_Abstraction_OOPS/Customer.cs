using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Static_Keyword_Following_Abstraction_OOPS
{
    internal class Customer
    {
        public string CustomeCode { get; set; }
        public string CustomeName { get; set; }
        public string MachineName { get; set; }

        public Customer()
        {
            CommonTask commonTask = new CommonTask();
            MachineName = commonTask.GetComputerName();
        }

        public void InsertInDB()
        {
            CommonTask commonTask = new CommonTask();   

            if(!commonTask.IsEmpty(CustomeName) && commonTask.IsEmpty(CustomeName))
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Demo
{
    internal class StringDataSource
    {
        private string[] strArr = new string[10];

        public string this[int index]
        {
            //get
            //{
            //    if (index < 0 || index >= strArr.Length)
            //        throw new IndexOutOfRangeException();
            //    return strArr[index];
            //}
            //set
            //{
            //    if (index < 0 || index >= strArr.Length)
            //        throw new IndexOutOfRangeException();
            //    strArr[index] = value;
            //}

            get => strArr[index];
            set => strArr[index] = value;
        }
    }
}

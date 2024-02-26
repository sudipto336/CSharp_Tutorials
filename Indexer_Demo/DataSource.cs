using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Demo
{
    internal class DataSource<T>
    {
        private T[] store;

        public DataSource(int length)
        {
           store  = new T[length];
        }

        public T this[int index]
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

            get => store[index];
            set => store[index] = value;
        }
    }
}

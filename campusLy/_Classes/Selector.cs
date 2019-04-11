using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campusLy._Classes
{
    internal class Selector
    {
        internal void AddIfNotExist(List<int> storage, int data)
        {
            if (isExisting(storage, data) == false)
                storage.Add(data);
        }

        internal bool isExisting(List<int> storage, int data)
        {
            int length = storage.Count;
            bool value;

            if (storage.Count == 0)
                value = false;
            else
            {
                int i;
                for (i = 0; i < length && storage[i] != data; i++) { }

                value = (i == length) ? false : true;
            }

            return value;
        }
    }
}

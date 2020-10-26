using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    public class CustomList<T>
    {
        private int count = 0;
        public int Count
        {
            get => count;
            set
            {
                count = value;
            }
        }
        private int capacity = 4;
        public int Capacity
        {
            get => capacity;
            set
            {
                if (Count > capacity)
                {
                    capacity = capacity * 2;
                }
            }
        }

        // member varialbe

        T[] items;
        public void Add(T item)
        {

        }
    }
}

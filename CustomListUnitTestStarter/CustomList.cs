using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    public class CustomList<T>
    {
        bool check;
        private int counter = 0;
        public int Counter
        {
            get => counter;
            //set
            //{
            //    count = value;
            //}
        }
        private int capacity = 4;
        public int Capacity
        {
            get => capacity;
            set
            {
                if ((Counter + 1) > capacity)
                {
                    capacity = capacity * 2;
                }
            }
        }
       // public CustomList()

        public int index = 0;
        
        T[] items;

        public void Add(T item)
        {
            CheckType(item);
            if (check)
            {
                    CustomListSize();

                    if (counter == 0)
                    {
                        items[index] = item;
                        counter = counter + 1;
                    }
                    else
                    {
                        items[index + 1] = item;
                        counter = counter + 1;
                        index = index + 1;
                    }
            }
            else
            {
                Console.WriteLine("That is not a valid data type");
            }
        }
        public bool CheckType(T item)
        {            check = true;
            //item.GetType();
            //items.GetType();
            if (item.GetType() == .GetType())
            {
                return check;
            }
            else 
            {
                check = false;
                return check;
            }

        }

        public void CustomListSize()
        {
            if (counter + 1 > capacity)
            {
                capacity = capacity * 2;

                Array.Resize<T>(ref items, capacity);
            }
            
        }
        public void Indexer()
        {

        }

        //public void removeItem(items, T item)
        //{
        //    foreach (var check in items)
        //    {
        //        if (check == item)
        //        {

        //        }
        //    }
        //}



    }
}


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
        public T this[int i]
        {
            if (int i <0 || int > capacity )
            {
                Console.WriteLine("this is an invalid selection;"  );
            else{
                 get { return items[i]; }
                 set { items[i] = value; }
                 }   
            }
        }

        public int index = 0;
       
        T[] items;
        public CustomList()
        {
            items = new T[capacity];
        }
        //     public T this[int i]
        //{
        //    if (int i <0 || int > capacity )
        //    {
        //        Console.WriteLine("this is an invalid selection;"  );
        //    else{
        //    get { return items[i]; }
        //    set { items[i] = value; }
        //    }   
        //    }
        //}
    
        public void Add(T item)
        {
            check = true;
            // CheckType(item);
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
        {
            check = true;
            //item.GetType();
            //items.GetType();
            if (item.GetType() == items.GetType())
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
                T[] itemTemp = new T[capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    itemTemp[i] = items[i];
                }
                items = itemTemp;
               //Array.Resize<T>(ref items, capacity);
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


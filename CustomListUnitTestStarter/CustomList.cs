using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    public class CustomList<T> : IEnumerable
    {// constructor

        // Read Only Counter
        bool check;
        private int counter = 0;
        public int Counter
        {
            get => counter;
            
        }
        // Initial Capacity and Controls
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
        // Indexer
        public T this[int i]
        {
            get
            {
                if (i >= 0 && i <= counter)
                {
                    return items[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                if (i >= 0 && i <= counter)
                {
                    items[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int index = 0;

        T[] items;

        public CustomList()
        {
            items = new T[capacity];

        }
        // Methods

       
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Counter; i++)
            {
                yield return items[i];
            }
        }
        
        // Adds a Specific Item to the List
        public void Add(T item)
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
        public bool CheckType(T item)
        {
            check = true;
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

        // Inctreass the Capacity of the List
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

            }

        }

        // Removes and Item from the List
        public void removeItem(T item)
        {
            switch (Counter)
            {

            case  0:
                    Console.WriteLine("There are no items to remove !");
                    break;

            default:
            for (int i = 0; i < counter; i++)
            {
                if (item.Equals(items[i]))
                {

                    for (int k = i; k < counter; k++)
                    {
                        items[k] = items[k + 1];
                    }
                    counter = counter - 1;
                    break;
                }

            }
                    break;
            }
        }

        // Combines Two Lists
        public CustomList<T> AddTwoLists(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.counter; i++)
            {
                newList.Add(list1[i]);
            }
            for (int i = 0; i < list2.counter; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }

        // Zips Two lists (alternating items to the new list)
        public CustomList<T> ZipTwoLists(CustomList<T> list1, CustomList<T> list2)
        {
            int tempCount;

            if (list1.counter > list2.counter)
            {
                tempCount = list1.counter;
            }
            else
            {
                tempCount = list2.counter;
            }

            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < tempCount; i++)
            {
                if(i< list1.counter)
                {
                    newList.Add(list1[i]);
                }
                if (i < list2.counter)
                {
                    newList.Add(list2[i]);
                }
            }
            return newList;
        }

        // + Operator Overload that combines two lists
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.counter; i++)
            {
                newList.Add(list1[i]);
            }
            for (int i = 0; i < list2.counter; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }
         // - operator Overload that removes like items from 2 lists
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {

            for (int i = 0; i < list1.counter; i++)
            {
                for (int j = 0; j < list2.counter; j++)
                {
                    if (EqualityComparer<T>.Default.Equals(list1[i], list2[j]))
                    {
                        for (int k = i; k < list1.counter; k++)
                        {
                            list1[k] = list1[k + 1];
                        }
                        i = i - 1;
                        list1.counter = list1.counter - 1;

                        for (int l = j; l < list2.counter; l++)
                        {
                            list2[l] = list2[l + 1];
                        }
                        j = j - 1;
                        list2.counter = list2.counter - 1;
                    }
                }
            }
            return list1;
        }
            
        // Method to remove like items from two lists
        public CustomList<T> SubLists(CustomList<T> list1, CustomList<T> list2)
        {
            //CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.counter; i++)
            {
                for (int j = 0; j < list2.counter; j++)
                {
                    if (EqualityComparer<T>.Default.Equals(list1[i], list2[j]))
                    {
                        for (int k = i; k < list1.counter; k++)
                        {
                            list1[k] = list1[k + 1];
                        }
                        i = i - 1;
                        list1.counter = list1.counter - 1;

                        for (int l = j; l < list2.counter; l++)
                        {
                            list2[l] = list2[l + 1];
                        }
                        j = j - 1;
                        list2.counter = list2.counter - 1;
                    }
                }
            }
            return list1;

        }
        // Takes a Custom list and converst the contents to a string
        public string ConvertToString(CustomList<T> list)
        {
            string temp = "";

            if (Counter == 0)
            {
                return temp;
            }
            else
            {
                
                for (int i = 0; i < list.Counter - 1; i++)
                {
                    temp += list[i].ToString();
                    temp += ", ";
                }
                temp += list[list.counter - 1].ToString();
                Console.WriteLine(temp);
                return temp;
            }
        }
    }

}


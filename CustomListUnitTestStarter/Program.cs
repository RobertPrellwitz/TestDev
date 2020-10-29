using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    class Program
    {
        static void Main(string[] args)
        {
         CustomList<int> numbers = new CustomList<int>();

            numbers.Add(4);
            numbers.Add(15);
            numbers.Add(20);
            numbers.Add(25);
            numbers.Add(25);
            numbers.Add(25);
            numbers.Add(30);

            Console.Clear();
            for (int i = 0; i <= numbers.index; i++)
            {
                Console.WriteLine($" yourlist contains {numbers[i]}");
               
            }
        Console.WriteLine();

            numbers.removeItem(25);

            for (int i = 0; i < numbers.index; i++)
            {
                Console.WriteLine($" yourlist contains {numbers[i]}");

            }
            CustomList<int> tempList = new CustomList<int>();
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);

            Console.WriteLine("Test List 1");
            for (int i = 0; i <= testList.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList[i]}");

            }

            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(15);
            testList2.Add(30);
            testList2.Add(45);

            Console.WriteLine("Test List 2");
            for (int i = 0; i <= testList2.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList2[i]}");

            }

            CustomList<int> combinedList = new CustomList<int>();

            combinedList=tempList.AddTwoLists(testList, testList2);

            for (int i = 0; i <= combinedList.index; i++)
            {
                Console.WriteLine($" your new list contains {combinedList[i]}");

            }

            CustomList<int> testList3 = new CustomList<int>();
            testList3.Add(1);
            testList3.Add(3);
            testList3.Add(5);
            testList3.Add(7);

            Console.WriteLine("Test List 3");
            for (int i = 0; i <= testList3.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList3[i]}");

            }

            CustomList<int> testList4 = new CustomList<int>();
            testList4.Add(2);
            testList4.Add(4);
            testList4.Add(6);
            testList4.Add(8);

            Console.WriteLine("Test List 4");
            for (int i = 0; i <= testList4.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList4[i]}");

            }



            CustomList<int> zipList = new CustomList<int>();

            zipList = tempList.ZipTwoLists(testList3, testList4);

            Console.WriteLine("Zip List");
            for (int i = 0; i <= zipList.index; i++)
            {
                Console.WriteLine($" yourlist contains {zipList[i]}");

            }
            

            CustomList<int> testList5 = new CustomList<int>();
            testList5.Add(10);
            testList5.Add(15);
            testList5.Add(20);
            CustomList<int> testList6 = new CustomList<int>();
            testList6.Add(10);
            testList6.Add(15);
            testList6.Add(20);

            CustomList<int> addList = new CustomList<int>();
            addList = testList5 + testList6;

            Console.WriteLine("Add Lists List");
            for (int i = 0; i <= addList.index; i++)
            {
                Console.WriteLine($" yourlist contains {addList[i]}");

            }

            CustomList<int> testList7 = new CustomList<int>();
            testList7.Add(3);
            testList7.Add(1);
            testList7.Add(5);
            CustomList<int> testList8 = new CustomList<int>();
            testList8.Add(2);
            testList8.Add(1);
            testList8.Add(6);


            CustomList<int> subList = new CustomList<int>();
            subList = testList7 - testList8;
            //subList = tempList.SubLists(testList7, testList8);

            Console.WriteLine("Sub Lists List");
            for (int i = 0; i <= subList.index; i++)
            {
                Console.WriteLine($" yourlist contains {subList[i]}");

            }
            string newString;
            newString = tempList.ConvertToString(numbers);
            
            Console.ReadLine(); Console.ReadLine();
        }


        
       



    }
}

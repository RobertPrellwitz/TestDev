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
        
        
            CustomList<int> tempList = new CustomList<int>();
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(25);
            testList.Add(30);

            Console.WriteLine("Test List 1");
            for (int i = 0; i <= testList.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList[i]}");

            }

            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(15);
            testList2.Add(30);
            testList2.Add(45);
            testList2.Add(45);
            testList2.Add(50);

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

            Console.WriteLine("\n\n test lists for subtraction method");
            Console.WriteLine("Test List 1");
            for (int i = 0; i <= testList.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList[i]}");

            }
            Console.WriteLine("Test List 2");
            for (int i = 0; i <= testList2.index; i++)
            {
                Console.WriteLine($" yourlist contains {testList2[i]}");

            }

            CustomList<int> subList = new CustomList<int>();
            subList = tempList.SubLists(testList, testList2);
            Console.WriteLine("\n\nNew List with like items removed from List 1 \n"  );
            foreach (var item in subList)
            {
                Console.WriteLine($"Number {item}");
            }

            Console.WriteLine();
            Console.WriteLine();


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
            Console.WriteLine("Zip list from For Each Loop!" );
            foreach (var item in zipList)
            {
                Console.WriteLine($" number {item}");
            }
            Console.ReadLine();

        }

    }
}

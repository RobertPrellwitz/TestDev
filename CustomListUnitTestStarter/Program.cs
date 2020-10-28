using System;
using System.Collections.Generic;
using System.Linq;
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

            combinedList.AddTwoLists(testList, testList2);

            for (int i = 0; i <= combinedList.index; i++)
            {
                Console.WriteLine($" your new list contains {combinedList[i]}");

            }
            CustomList<int> zipList = new CustomList<int>();

            zipList.ZipTwoLists(testList, testList2);
        }


    }
}

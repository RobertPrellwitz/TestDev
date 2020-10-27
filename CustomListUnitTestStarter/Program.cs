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

            Console.ReadLine();
        }
        
    }
}

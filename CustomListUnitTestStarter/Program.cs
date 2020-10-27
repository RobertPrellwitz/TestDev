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

            List<int> test = new List<int>();
            test.Add(5);
            test.Add(10);
            test.Add(12);
            test.Add(19);
            test.Add(67);


        }
    }
}

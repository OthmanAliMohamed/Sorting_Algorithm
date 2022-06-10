using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 8, 2, 4, 1, 3 };
            Sorting sorter = new Sorting();
            sorter.Selection_Sort(numbers);
            sorter.Print(numbers);
            Console.ReadKey();
        }
    }
}

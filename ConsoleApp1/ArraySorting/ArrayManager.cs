using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace SecondTask.ArraySorting
{
    public class ArrayManager
    {
        public void SplittArray()
        {
            var arr = new int[] { 2, 3, 3, 2, 4 };

            List<int> evenList = arr.Where(item => item % 2 == 0).ToList();
            List<int> oddList = arr.Where(item => item % 2 == 1).ToList();

            Console.WriteLine("Even numbers:");
            foreach (var item in evenList)
                Console.WriteLine(item);

            Console.WriteLine("Odd numbers:");
            foreach (var item in oddList)
                Console.WriteLine(item);

        }
    }
}
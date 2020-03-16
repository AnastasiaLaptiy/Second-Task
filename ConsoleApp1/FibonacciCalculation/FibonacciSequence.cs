using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask.FibonacciCalculation
{
    public class FibonacciSequence
    {
        public void FibonacciCounter(int n)
        {
            int firstElement = 0;
            int secondElement = 1;

            Console.WriteLine("Fibonacci sequence via cycle:");

            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement);
            for (int i = 0; i < n; i++)
            {
                int result = firstElement + secondElement;
                firstElement = secondElement;
                secondElement = result;
                Console.WriteLine(result);
            }
        }

        public void FibonacciCounterLINQ(int n)
        {
            int firstElement = 0;
            Console.WriteLine(firstElement);

            List<int> fibonacciList = new List<int>();
            Enumerable.Range(0, n)
                .ToList()
                .ForEach(f => fibonacciList
                .Add(f <= 1 ? 1 : fibonacciList[f - 2] + fibonacciList[f - 1]));

            Console.WriteLine("Fibonacci sequence via LINQ:");
            foreach (int item in fibonacciList)
            {
                Console.WriteLine(item);
            }
        }

        public void FibonacciAggr(int n)
        {
            Console.WriteLine("Fibonacci sequence via LINQ v2:");
            List<int> fibonacciList = new List<int>();
            while (n > 0) { 
                fibonacciList.Add(
                Enumerable.Range(0, n).Skip(2).ToList().Aggregate(new { Previous = 1, Current = 1 },
                (element, idx) => new { Previous = element.Current, Current = element.Current + element.Previous }).Current);

                n--;
            }

            foreach (var item in fibonacciList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using SecondTask.FactorialAction;
using SecondTask.FibonacciCalculation;
using SecondTask.ArraySorting;
using SecondTask.TeaSorting.Managers;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task:");
            FibonacciSequence fibonacciSequence = new FibonacciSequence();
            fibonacciSequence.FibonacciCounter(10);
            fibonacciSequence.FibonacciCounterLINQ(11);

            Console.WriteLine("Second task:");
            Factorial factorialResult = new Factorial();
            factorialResult.FactorialCounter(7);

            Console.WriteLine("Third task:");
            TeaManager teaManager = new TeaManager();
            teaManager.GroupingTeaItem(teaManager.GetListTea());

            Console.WriteLine("Forth task:");
            ArrayManager arrayManager = new ArrayManager();
            arrayManager.SplittArray_v1();
            arrayManager.SplittArray_v2();

            Console.ReadKey();
        }
    }
}

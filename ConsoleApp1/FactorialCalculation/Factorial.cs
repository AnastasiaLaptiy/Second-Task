using System;
using System.Linq;

namespace SecondTask.FactorialAction
{
    public class Factorial
    {
        public void FactorialCounter(int n)
        {
            var arr = Enumerable.Range(1, n).Aggregate((firstNum, nextNum) => firstNum * nextNum);
            Console.WriteLine($"Factorial: {arr}");       
        }
    }
}

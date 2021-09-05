using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            var DelUnoAlCien = PopulateList();
            var FizzBuzz = new FizzBuzz();
        }
        private static IEnumerable<int> PopulateList()
        {
            var list = new List<int>();
            for (var r = 1; r < 100; r++)
            {
                list.Add(r);
            }

            return list;
        }
    }
}

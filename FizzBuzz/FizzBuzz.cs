using System;

namespace FizzBuzz
{

    //Fizz Buzz works as follows.It receives a number as input and it outputs one of the following 4 things:

    //If the number is divisible by three, the function should output Fizz.
    //If the number is divisible by five, the function should output Buzz.
    //If the number is divisible by both three AND five, the function should output Fizz Buzz.
    //Otherwise, an empty string is returned.

    public class FizzBuzz
    {
        public string DoFizzBuzz(int x)
        {
            string result = string.Empty;
            if (x < 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (x % 3 is 0)
            {
                result = string.Concat(result, "Fizz");
            }

            if (x % 5 is 0)
            {
                result = string.Concat(result, "Buzz");
            }

            return result;
        }
    }
}
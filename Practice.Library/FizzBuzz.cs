using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Library
{
    public class FizzBuzz
    {
        public List<string> PerformAction(int numberToGoTo)
        {
            var returnValues = new List<string>();

            for (int i = 1; i <= numberToGoTo; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) returnValues.Add("fizzbuzz");
                else if (i % 3 == 0) returnValues.Add("fizz");
                else if (i % 5 == 0) returnValues.Add("buzz");
                else returnValues.Add(i.ToString());
            }

            return returnValues;
        }
    }
}

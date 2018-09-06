using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Library
{
    public class Fibonacci
    {
        public List<string> PerformAction(int numberToGoTo)
        {
            var returnValues = new List<string>();

            int a = 0;
            int b = 1;
            int c = 0;

            returnValues.Add(a.ToString());
            returnValues.Add(b.ToString());

            for (int i = 2; i < numberToGoTo; i++)
            {
                c = a + b;

                returnValues.Add(c.ToString());

                a = b;
                b = c;
            }

            return returnValues;
        }
    }
}

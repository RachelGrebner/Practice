using Practice.Library;
using System;

namespace Practice.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.Run();
        }
    }

    public class Runner
    {
        public void Run()
        {
            try
            {
                do
                {
                    int userInput = InputIO.GetIntegerInput();

                    var fizzBuzz = new FizzBuzz();
                    var results = fizzBuzz.PerformAction(userInput);

                    //var fibonacci = new Fibonacci();
                    //var results = fibonacci.PerformAction(userInput);

                    results.ForEach(r => Console.WriteLine(r));

                } while (InputIO.GetTrueFalseInput());

            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
    }
}

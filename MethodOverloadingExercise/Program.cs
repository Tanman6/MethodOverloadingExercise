using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 49;
            var y = 19;

            var intAnswer = Add(x, y);
            var decAnswer = Add(3.6m, 4.5m);
            var stringAnswer = Add("one, ", "two, ", "three.");
            var dollarAnswer = Add(9, 11, true);

            Console.WriteLine($"Integer answer: {intAnswer} \n" +
            $"Decimal answer: {decAnswer} \n" +
            $"String answer: {stringAnswer}\n" +
            $"Dollar amount answer: {dollarAnswer}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static string Add(string x, string y, string z)
        {
            return x + y + z;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            var sum = x + y;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"0 Dollars and {sum} cents";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}

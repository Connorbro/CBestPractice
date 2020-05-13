using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLargerNumber(31, 85, 129));


        }
        static int GetLargerNumber(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if(num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}

using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser("Connor", 21);
            HelloUser("Leonie", 26);
            Console.WriteLine(cubedNumber(3));

           
        }
        static void HelloUser(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age} years old");
        }
        static int cubedNumber(int num)
        {
            int result = num * num * num;
            return result;
         }
    }
}

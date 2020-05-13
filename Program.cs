using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser("Connor", 21);
            HelloUser("Leonie", 26);

           
        }
        static void HelloUser(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age} years old");
        }
    }
}

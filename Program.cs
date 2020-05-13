using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser("Connor");

           
        }
        static void HelloUser(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}

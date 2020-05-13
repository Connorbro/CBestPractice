using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Connor");
            
            Console.ReadLine();
        }
        static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}

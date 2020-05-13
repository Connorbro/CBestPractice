using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {
            WhatAgeShouldYouBe(12);


        }
        static void WhatAgeShouldYouBe(int age)
        {
            
            if(age >= 18)
            {
                Console.WriteLine("Yes you can buy a beer");
            }
            else
            {
                Console.WriteLine("No you're too young");
            }
        }
    }
}

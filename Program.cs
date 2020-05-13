using System;

namespace BestPracticeC
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        static void WhatAgeShouldYouBe()
        {
            var age = 18;
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

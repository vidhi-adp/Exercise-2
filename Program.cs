using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            int height = 162;
            int max_heart_rate;
            max_heart_rate = 220 - age;
            Console.WriteLine("I am " + age + " years old, my max heart rate is " + max_heart_rate + " and I am " + height + " inches tall.");
        }
    }
}

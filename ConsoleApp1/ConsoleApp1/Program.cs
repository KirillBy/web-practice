using System;

namespace ConsoleApp1
{
    enum gender{
        male,
        female, 
        other
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)gender.other);
        }
    }
}

using System;

namespace RejexEmailDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Email Pattern Check Problem");
            Pattern p = new Pattern();
            bool result = p.Check("abc-100@abc.net,");
            Console.WriteLine(result);
        }
    }
}

using System;
using MySolution.MyService;

namespace MySolution.MyLogger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hello = MyClass.SayHello();
            Console.WriteLine(hello);
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 instance = new ClassLibrary1.Class1();

            int sum = instance.addNums(2, 4);

            Console.WriteLine("Hello World! The sum is: " + sum.ToString());
            Console.Read();
        }
    }
}

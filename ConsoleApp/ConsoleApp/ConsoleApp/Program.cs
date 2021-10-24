using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            count = int.Parse(Console.ReadLine());
            var data = "";
            Console.WriteLine("データ個数:" + count);
            for (var i = 0; i < count; i++)
            {
                data = Console.ReadLine();
                Console.WriteLine("hello " + data);
            }
        }
    }
}

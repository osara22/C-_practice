using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var omikuji = random.Next(1, 5);
            Console.WriteLine(omikuji);
            if (omikuji == 1)
            {
                Console.WriteLine("大吉");
            }
            else if (omikuji == 2)
            {
                Console.WriteLine("中吉");
            }
            else if (omikuji == 3)
            {
                Console.WriteLine("小吉");
            }
            else
            {
                Console.WriteLine("凶");
            }
        }
    }
}

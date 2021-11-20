using System;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    fibonacci();
    Console.WriteLine();
    toribonacci();
    Console.WriteLine();
    tetoranacci();
  }

  static void fibonacci()
  {
    int[] f = { 0, 1 };
    int sum = 0;
    Console.Write(f[0] + "," + f[1] + f.Sum());
    for (int i = 0; i < 10; i++)
    {
      sum = f.Sum();
      f[0] = f[1];
      f[1] = sum;
      Console.Write("," + f.Sum());
    }
  }

  // トリボナッチ数列
  static void toribonacci()
  {
    int[] f = { 0, 0, 1 };
    int sum = 0;
    Console.Write(f[0] + "," + f[1] + "," + f[2] + "," + f.Sum());
    for (int i = 0; i < 10; i++)
    {
      sum = f.Sum();
      f[0] = f[1];
      f[1] = f[2];
      f[2] = sum;
      Console.Write("," + f.Sum());
    }
  }

  // テトラナッチ数列
  static void tetoranacci()
  {
    int[] f = { 0, 0, 0, 1 };
    int sum = 0;
    Console.Write(f[0] + "," + f[1] + "," + f[2] + "," + f[3] + "," + f.Sum());
    for (int i = 0; i < 10; i++)
    {
      sum = f.Sum();
      f[0] = f[1];
      f[1] = f[2];
      f[2] = f[3];
      f[3] = sum;
      Console.Write("," + f.Sum());
    }
  }
}


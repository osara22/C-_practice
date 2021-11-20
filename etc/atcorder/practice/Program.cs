using System;

class Program
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    string[] input = Console.ReadLine().Split(' ');
    int L = 0;
    int total = 0;
    int huge = 0;
    for (int i = 0; i < N; i++)
    {
      L = int.Parse(input[i]);
      if (L > huge)
      {
        huge = L;
        break;
      }
      total += L;
    }

    if (huge < total)
    {
      Console.WriteLine("Yes");
    }
    else
    {
      Console.WriteLine("No");
    }
  }
}


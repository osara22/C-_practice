using System;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    int a, b, c;
    string[] uhen = new string[101];

    for (c = 0; c <= 100; c++)
    {
      uhen[c] = Convert.ToString(c * c);
    }

    int sahen = 0;
    for (a = 1; a <= 100; a++)
    {
      for (b = 1; b <= 100; b++)
      {
        sahen = (a * a) + (b * b);
        if (uhen.Contains(sahen.ToString()))
        {
          Console.WriteLine("(" + a + " * " + a + ") + (" + b + " * " + b + ") = " + sahen);
        }
      }
    }
  }
}


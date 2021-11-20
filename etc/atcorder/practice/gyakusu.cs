using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    double array = 0;
    double i = 0;
    for (;;)
    {
      i++;
      array += (1 / i);
      if(array >= 12){
        Console.WriteLine(array + " " + i);
        break;
      }
    }
  }
}

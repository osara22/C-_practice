// https://atcoder.jp/contests/abc117/tasks/abc117_b
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main(string[] args)
  {
    long array = 0;

    for(int i = 1; i <= 100; i++){
      array += i * i * i *i;
    }
    Console.WriteLine(array);
  }
}

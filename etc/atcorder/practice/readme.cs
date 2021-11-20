using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
  class readme
  {
    static void Main(string[] args)
    {
      // プログラミングテストに向けて

      // 少数点以下が出る計算はdouble型を使う
      // 例
      double answer = (double)T / X;

      // スペースを使って分割されている入力はLINQのSelect句を用いて一行で配列に入れる
      // 例
      int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
      // .ToArrayとは配列にするよという宣言

      List<int> x = Console.ReadLine().Split().Select(int.Parse).ToList();
      // .ToListとはListにするよという宣言

      l.Sum()
      // .Sum()は配列内の数値をすべて合計するよという宣言

      Math.Abs(x[i+1]-x[i])
      // Math.Abs()は絶対値を返す(すべて正の数で返す)

      Array.Sort(l)
      // Array.Sortは昇順に並べ替えるという宣言

      Console.WriteLine(solve(1, 2));
    }

    static int solve(int n, int m)
    {
      return n + m;
    }
  }
}

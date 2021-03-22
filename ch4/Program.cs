using System;

namespace ArrayAndString {
  class ArrStr {
    static void Main(string[] args) {
      int[] userAges = {1, 2, 3, 4};
      int[] ages2 = new [] {7,6,31, 2, 3, 4};
      int[] ages3 = new int[4];
      ages3[0] = 1;

      Console.WriteLine("length");
      Console.WriteLine(ages2.Length);

      Array.Copy(userAges, ages3, 2);
      Console.WriteLine("newly copied length should be 2");
      Console.WriteLine(ages3.Length);
      Array.Sort(ages2);
      Console.WriteLine("Ages 2");
      foreach (int age in ages2) {
          Console.WriteLine(age);
      }
      int idx1 = Array.IndexOf(ages2, 21);
      int idx2 = Array.IndexOf(ages2, 31);
      Console.WriteLine(idx1);
      Console.WriteLine(idx2);

      string name1 = "Great man";
      string name = name1 + " oh yeah";
      Console.WriteLine(name);
      Console.WriteLine(name.Substring(5, 5));

      Console.WriteLine(name1.Equals(name1));
    }
  }
}

using System;

namespace FirstCSharp {
    class ClassOne  {
        static void Main(string[] args) {
            Console.WriteLine("Hello?");
            int a = 10;
            decimal b = 5.1M;
            double c = 2.2;
            char d = 'a';
            a /= 2;
            a++;
            a %= 4;
            int e = (int)b;
            Console.WriteLine(a);
            Console.WriteLine(e);
            Console.Read();
        }
    }
}
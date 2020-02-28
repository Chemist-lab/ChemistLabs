using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public int Example(int a, int b, int c )
        {
            int s = 2 * (a * b + b * c + a * c);
            int v = a* b *c;
            Console.WriteLine("S = " + s + "\n" + "V = " + v);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть a");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Console.WriteLine("Введiть b");
            string S2 = Console.ReadLine();
            int b = int.Parse(S2);
            Console.WriteLine("Введiть c");
            string S3 = Console.ReadLine();
            int c = int.Parse(S3);
            Example(a, b, c);
            Console.ReadLine();
        }
    }
}

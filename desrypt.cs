using System;
using System.Text;
 
namespace FirtsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "#";
            // string source = Console.ReadLine();
            StringBuilder res = new StringBuilder(source.Length / 5);
            int delta = 5;
            for (int i = delta - 1; i < source.Length; i += delta)
                res.Append(source[i]);
            Console.WriteLine(res);
 
        }
    }
}

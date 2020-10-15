using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "LOGITpe20";
            Console.WriteLine($"{someString.Length}");
            string newString = someString.Substring(0, 5);
            Console.WriteLine(newString);
            string polationString = someString.Substring(5, 2);
            Console.WriteLine(polationString);
            string pe = someString.Substring(7, 2);
            Console.WriteLine(pe);
        }
    }
}

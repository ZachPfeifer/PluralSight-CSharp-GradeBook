using System;

namespace GradeBook
{
    class Program
    {
        //Method Main
        static void Main(string[] args)
        {
           if( args.Length > 0)
           {
            Console.WriteLine($"Hello, {args[0]}!");
           }
           else
           {
            Console.WriteLine( "Hello!");
           }
        }
    }
}

using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //Method Main
        static void Main(string[] args)
        {
//SECTION Grades
             //NOTE var represents Double(auto detect the data-type)
            //    var x = 34.1;
            //    var y = 10.3;
            //    var result = x + y;
            //    Console.WriteLine(result);

            //NOTE initilizing array of double data-type numbers
            var numbers = new [] {12.7,10.3, 6.11, 4.1};
            //NOTE List are used to dynamically add and remove objects from List/Array(only data-type doubles can be added to Generic List here)
            var grades = new List<double>(){12.7,10.3, 6.11, 4.1};
            grades.Add(56.1);
        
            var result= 0.0;
            foreach(var number in grades)
            {
               result += number;
            }
            result /=grades.Count;
            //NOTE N2 is similar to .toFixed(2)
            Console.WriteLine($"The average grade is {result:N2}");


//SECTION Greeting
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

using System;
using System.Collections.Generic;

namespace GradeBook
{


    class Program
    {
        //Method Main
        static void Main(string[] args)
        {
//SECTION Book
            var book = new Book("Zach's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

//SECTION Grades
            //NOTE var represents Double(auto detect the data-type)
            //NOTE initilizing array of double data-type numbers
            //NOTE List are used to dynamically add and remove objects from List/Array(only data-type doubles can be added to Generic List here)
            var grades = new List<double>(){12.7,10.3, 6.11, 4.1};
            grades.Add(56.1);
        
            var result= 0.0;
            var highGrade = double.MinValue;
            var lowGrade= double.MaxValue;
            foreach(var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade= Math.Max(number, highGrade);
               result += number;
            }
            result /=grades.Count;
            //NOTE N2 is similar to .toFixed(2)
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The average grade is {result:N2}");
        }
    }
}

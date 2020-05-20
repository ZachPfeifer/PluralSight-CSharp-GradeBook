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
            book.ShowStatistics();
//SECTION Grades
            // //NOTE var represents Double(auto detect the data-type)
            // //NOTE initilizing array of double data-type numbers
            // //NOTE List are used to dynamically add and remove objects from List/Array(only data-type doubles can be added to Generic List here)
            //FIXME abstracted logic to Book.cs under ShowStatistics and grades is just the List/Field varable 
            // var grades = new List<double>(){12.7,10.3, 6.11, 4.1};
            // grades.Add(56.1);
        
           
        }
    }
}

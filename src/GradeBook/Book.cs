using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
//NOTE Contstructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
//NOTE AddGrade is an Instance method of Book
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
//NOTE Field is an Instance field of Book (Cannot use inplicit must be explicit)
       private List<double> grades;  
       private string name;
    }
}
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.AddGrade(70);
            book1.AddGrade(80);
            book1.AddGrade(40);
            book1.AddGrade(50);
            book1.AddGrade(80);
            book1.AddGrade(20);
            book1.AddGrade(10);
            book1.AddGrade(83);
            book1.AddGrade(56);
            book1.AddGrade(76);

            var st = book1.GetStatistics();
            
            System.Console.WriteLine($"The Highest grade is {st.High}");
            System.Console.WriteLine($"The Lowest grade is {st.Low}");
            System.Console.WriteLine($"The Average grade is {st.Average}");
        }
    }
}
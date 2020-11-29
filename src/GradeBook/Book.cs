using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> gradeList;

        public Book()
        {
            gradeList = new List<double>();
        }

        public void AddGrade(double grade)
        {
            gradeList.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var stat = new Statistics();
            stat.Average = 0.0;
            stat.Low = double.MaxValue;
            stat.High = double.MinValue;

            foreach (var number in gradeList)
            {
                stat.Low = Math.Min(number, stat.Low);
                stat.High = Math.Max(number, stat.High);
                stat.Average += number;
            }

            stat.Average /= gradeList.Count;

            return stat;

        }
    }
}
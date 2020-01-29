using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book {
        public Book (string name) {
            //can also use this.Name = name
            Name = name;
            Grades = new List<double> ();
        }
        public void AddGrade (double grade) {
            Grades.Add (grade);
        }

        public void ShowStatistics () {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in Grades) {
                lowGrade = Math.Min (number, lowGrade);
                highGrade = Math.Max (number, highGrade);
                result += number;
            }
            result /= Grades.Count;
            //:N1 is a formatter that specifies that it is a number with 1 decimal place precision
            Console.WriteLine ($"The lowest grade is {lowGrade:N1}.");
            Console.WriteLine ($"The highest grade is {highGrade:N1}.");
            Console.WriteLine ($"The average grade is {result:N1}.");
        }

        private List<double> Grades;
        private string Name;
    }
}
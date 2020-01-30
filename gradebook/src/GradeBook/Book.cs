using System;
using System.Collections.Generic;

namespace GradeBook {
    public class Book {
        public Book (string name) {
            //can also use this.Name = name
            Name = name;
            Grades = new List<double> ();
        }

        public void AddLetterGrade (char letter) {
            switch (letter) {
                case 'A':
                    AddGrade (90);
                    break;
                case 'B':
                    AddGrade (80);
                    break;
                case 'C':
                    AddGrade (70);
                    break;
                case 'D':
                    AddGrade (60);
                    break;
                case 'F':
                    AddGrade (50);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade (double grade) {
            if (grade <= 100 && grade >= 0) {
                Grades.Add (grade);
            }
        }

        public Statistics GetStatistics () {
            var result = new Statistics ();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in Grades) {
                result.Low = Math.Min (grade, result.Low);
                result.High = Math.Max (grade, result.High);
                result.Average += grade;
            }

            result.Average /= Grades.Count;

            return result;
        }

        private List<double> Grades;
        public string Name;
    }
}
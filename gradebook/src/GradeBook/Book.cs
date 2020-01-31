using System;
using System.Collections.Generic;

namespace GradeBook {
    public delegate void GradAddedDelegate(object sender, EventArgs args);

    public class Book {
        public Book (string name) {
            //can also use this.Name = name
            Name = name;
            Grades = new List<double> ();
        }

        public void AddGrade (char letter) {
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
                    AddGrade (0);
                    break;
            }
        }

        public void AddGrade (double grade) {
            if (grade <= 100 && grade >= 0) {
                Grades.Add (grade);
                if(GradeAdded != null){
                    GradeAdded(this, new EventArgs());
                }
            } else {
                throw new ArgumentException ($"Invalid {nameof(grade)}");
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

            switch (result.Average) {
                case var d when d >= 90:
                    result.Letter = 'A';
                break;
                case var d when d >= 80:
                    result.Letter = 'B';
                break;
                case var d when d >= 70:
                    result.Letter = 'C';
                break;
                case var d when d >= 60:
                    result.Letter = 'D';
                break;
                case var d when d >= 50:
                    result.Letter = 'F';
                break;
            }

            return result;
        }

        private List<double> Grades;
        public string Name {
            get; 
            set;
        }
        public event GradAddedDelegate GradeAdded;
        //Const variables cannot be set, not even in the constructor and are treated like static, where you have to access it through the class name.
        //Readonly variables can only be set in the constructor
        public const string CATEGORY = "Science";
    }
}
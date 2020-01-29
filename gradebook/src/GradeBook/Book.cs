using System.Collections.Generic;

namespace GradeBook 
{
    public class Book 
    {
        public Book(string name){
            //can also use this.Name = name
            Name = name;
            Grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        private List<double> Grades;
        private string Name;
    }
}
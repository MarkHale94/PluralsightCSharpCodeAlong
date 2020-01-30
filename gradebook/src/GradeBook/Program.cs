using System;
using System.Collections.Generic;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            //cw can be used as shorthand for the console.writeline
            //ctrl . can be used to access the quick fixes
            // /= can be used like += for shorthand of math operations
            //ctrl k+c can also be used for commenting out lines of code
            //ctrl k+u can be used to uncomment lines
            //static methods prevents the field from being instantiated with the object and can only be used through the class. Console.WriteLine is an example of a static method. You don't need to instantiate a new console in order to be able to use the writeline method.

            var book = new Book ("Mark's Gradebook");
            book.AddGrade (89.1);
            book.AddGrade (42.3);
            var stats = book.GetStatistics ();

            //:N1 is a formatter that specifies that it is a number with 1 decimal place precision
            Console.WriteLine ($"The lowest grade is {stats.Low:N1}.");
            Console.WriteLine ($"The highest grade is {stats.High:N1}.");
            Console.WriteLine ($"The average grade is {stats.Average:N1}.");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //cw can be used as shorthand for the console.writeline
            //ctrl . can be used to access the quick fixes
            // /= can be used like += for shorthand of math operations

            var grades = new List<double>(){12.7, 10.3, 6.11, 4.1};

            var result = 0.0;
            foreach(double number in grades){
                result += number;
            }
            result /= grades.Count;
            //:N1 is a formatter that specifies that it is a number with 1 decimal place precision
            Console.WriteLine($"The average grade is {result:N1}.");

            if(args.Length > 0){
                Console.WriteLine($"Hello, {args[0]}");
            }
            else{
                Console.WriteLine("Hello");
            }
        }
    }
}

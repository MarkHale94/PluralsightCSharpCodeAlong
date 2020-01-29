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

            var numbers = new [] {12.7, 10.3, 6.11, 4.1};
            var grades = new List<double>(){12.7, 10.3, 6.11, 4.1};

            var result = 0.0;
            foreach(double number in grades){
                result += number;
            }
            Console.WriteLine(result);

            if(args.Length > 0){
                Console.WriteLine($"Hello, {args[0]}");
            }
            else{
                Console.WriteLine("Hello");
            }
        }
    }
}

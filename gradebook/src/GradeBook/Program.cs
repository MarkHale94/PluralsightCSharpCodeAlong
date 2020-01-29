using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {12.7, 10.3, 6.11, 4.1};
            //double x = 31.12;
            //double y = 42.7;
            Console.WriteLine(numbers[0]);
            if(args.Length > 0){
                Console.WriteLine($"Hello, {args[0]}");
            }
            else{
                Console.WriteLine("Hello");
            }
        }
    }
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            Student student = new Student();
            student.StudentId = 1;
            student.StudentName = "Hexagon";
            student.Question = "Can Nasa save IronMan?";
            Console.WriteLine($"Student {student.StudentName} has a question");
            Console.WriteLine(student.Question);
            Console.ReadLine();
        }
    }
}

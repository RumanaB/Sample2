using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //hey there Hexagon!!  This is a new line
            Console.WriteLine("Hello Github!");
            Student student = new Student();
            student.StudentId = 1;
            student.StudentName = "Hexagon";
            student.Question = "Can Captain America save IronMan?"; //this line has been modified
            Console.WriteLine($"Student {student.StudentName} has a question");
            Console.WriteLine(student.Question);
            
            //the line above was removed
        }
    }
}

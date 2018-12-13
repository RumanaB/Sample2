using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added a login functionality
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (username == "Rumzi" && password == "Rumzi")
            {
                Console.WriteLine("Hello Github!");
                Student student = new Student();
                student.StudentId = 1;
                student.StudentName = "Hexagon";
                student.Question = "Can Elon Musk save IronMan?";
                Console.WriteLine($"Student {student.StudentName} has a question");
                Console.WriteLine(student.Question);
            }
            else
                Console.WriteLine("Ahoy Imposter!");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Student student = new Student("Alex", "Odin", 26, "Zhytomir");
        Course course1 = new Course("SQL", "Krystyna Hurieieva", 20, 11);
        student.AddCourse(course1);
        Course course2 = new Course("Scrum & Agile practices", "Bogdan Misyura", 12, 6);
        student.AddCourse(course2);
        student.DescribeYourself();
        Console.WriteLine("------------------------");


        student.RemoveCourse(course2);
        student.DescribeYourself();
        Console.WriteLine("------------------------");


        Course course3 = new Course("C# ", "Krystyna Hurieieva", 20, 12);
        course3.AddStudent(student);
        course3.DescribeYourself();
        Console.WriteLine("------------------------");


        Teacher teacher = new Teacher("Krystyna", "Hurieieva", 25, "Lviv");
        teacher.AddStudent(student);
        teacher.AddCourse(course3);
        teacher.DescribeYourself();
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> coursesAttended = new List<string> { "SQL" };
        Student student = new Student("Alex", "Odin", 20, "Zhytomir", coursesAttended);

        student.DescribeYourself();
        student.AddCourse("C# part 1");
        student.DeleteCourse("SQL");
        Console.WriteLine("------------------------");

        student.DescribeYourself();
        Console.WriteLine("------------------------");

        Teacher teacher = new Teacher("Krystyna", "Hurieieva", 25, "Lviv", "C# part 1 and SQL");
        teacher.DescribeYourself();
    }
}
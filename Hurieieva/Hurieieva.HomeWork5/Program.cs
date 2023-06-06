static class Program
{


    static void Main(string[] args)
    {

        List<string> coursesAttended = new List<string> { "SQL (gr#14)" };
        Student student = new Student("Alex", "Odin", 20, "Zhytomir", coursesAttended);

        student.Print();
        Console.WriteLine("------------------------");

        student.AddCourse("C# part 1 (gr#3)");
        student.Print();
        Console.WriteLine("------------------------");

        student.DeleteCourse("SQL (gr#14)");
        student.Print();
        Console.WriteLine("------------------------");

        Course course = new Course("C# part 1 (gr#3) ", "Krystyna Hurieieva", 18, 12);
        course.Print();
        Console.WriteLine("------------------------");
        course.AddStudent();

        course.Print();

    }
}

public class Student : Person
{
    public List<Course> Courses { get; set; }

    public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
    {
        Courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        Courses.Remove(course);
    }

    public override void DescribeYourself()
    {
        base.DescribeYourself();
        Console.WriteLine("Courses attended:");
        foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course.CourseName} ({course.TeacherName})");
        }
    }
}

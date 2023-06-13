public class Teacher : Person
{
    public List<Student> Students { get; set; }
    public List<Course> Courses { get; set; }

    public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
    {
        Students = new List<Student>();
        Courses = new List<Course>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
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
        Console.WriteLine("Courses:");
        foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course.CourseName} ({course.NumberOfStudents} students)");
        }
    }
}

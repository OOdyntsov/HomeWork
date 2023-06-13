public class Course
{
    public string CourseName { get; set; }
    public string TeacherName { get; set; }
    public int CourseDuration { get; set; }
    public int NumberOfStudents { get; set; }
    public List<Student> Students { get; set; }

    public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents)
    {
        CourseName = courseName;
        TeacherName = teacherName;
        CourseDuration = courseDuration;
        NumberOfStudents = numberOfStudents;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
        NumberOfStudents++;
    }

    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
        NumberOfStudents--;
    }

    public void DescribeYourself()
    {
        Console.WriteLine($"Course: {CourseName}, Teacher: {TeacherName}, Duration: {CourseDuration} hours, Students: {NumberOfStudents}");
    }
}

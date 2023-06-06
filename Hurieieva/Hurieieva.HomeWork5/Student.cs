class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public List<string> CoursesAttended { get; set; }

    public Student (string firstName, string lastName , int age, string city, List<string> coursesAttended)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        City = city;
        CoursesAttended = coursesAttended;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine("Courses Attended:");
        foreach (string course in CoursesAttended)
        {
            Console.WriteLine($"- {course}");
        }
    }
    public void AddCourse(string course)
    {
        CoursesAttended.Add(course);
    }

    public void DeleteCourse(string course)
    {
        CoursesAttended.Remove(course);
    }
}





class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string firstName, string lastName, int age, string city, string subject) : base(firstName, lastName, age, city)
    {
        Subject = subject;
    }

    public override void DescribeYourself()
    {
        base.DescribeYourself();
        Console.WriteLine($"I am a teacher of: ({Subject}) Courses");
    }
}

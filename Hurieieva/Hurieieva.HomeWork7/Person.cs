public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Person(string firstName, string lastName, int age, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        City = city;
    }

    public virtual void DescribeYourself()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}, City: {City}");
    }
}

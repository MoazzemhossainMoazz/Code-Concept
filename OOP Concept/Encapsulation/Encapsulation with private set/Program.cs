class Student
{
    public string Name { get; private set; }
    public Student(string name)
    {
        Name = name;
    }

    public void UpdateName(string newName)
    {
        if (!string.IsNullOrWhiteSpace(newName))
            Name = newName;
        else
            throw new ArgumentException("Name cannot be empty.");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Bob");
        Console.WriteLine(student.Name);

        student.UpdateName("Robert");
        Console.WriteLine(student.Name);
    }
}
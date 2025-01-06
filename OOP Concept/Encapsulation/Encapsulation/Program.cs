class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                throw new ArgumentException("Name cannot be emplty.");
        }
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "John";
        Console.WriteLine(person.Name);
    }
}



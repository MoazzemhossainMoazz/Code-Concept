class Employee
{
    private int id;
    private string name;

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {id}, Name: {name}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee(1, "Alice");
        emp.DisplayDetails();
    }
}
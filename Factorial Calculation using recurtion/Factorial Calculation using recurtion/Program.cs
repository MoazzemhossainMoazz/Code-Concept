class Program
{
    static void Main(string[] args)
    {
        int i, fact, num;

        Console.WriteLine("Enter a number:");
        num = int.Parse(Console.ReadLine());

        fact = num;
        for(i = num-1; i >0; i--)
        {
            fact = fact * i;
        }
        Console.WriteLine("The factorial value is: " + fact);
        Console.ReadKey();
    }
        
}
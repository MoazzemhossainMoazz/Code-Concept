using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int remainder=0, reverse=0, num=0, original;
            Console.WriteLine("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        original = num;

        while(num != 0)
        {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num = num / 10; 
        }

        if(original == reverse)
        {
            Console.WriteLine("This num is palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not palindrome");
        }
    }
}

// char, array, reverse, 
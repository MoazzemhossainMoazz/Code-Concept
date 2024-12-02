using System;
using System.Reflection.Metadata.Ecma335;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string word:");
            string myString = Console.ReadLine();
            int myLength = myString.Length;
            for(int i = 0; i<myLength/2; i++)
            {
                if (myString[i] != myString[myLength - i - 1])
                    Console.WriteLine("Not palindrome"); 
            }
            Console.WriteLine("palindrome");
        }
    }
}

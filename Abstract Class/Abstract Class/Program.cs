//Abstact class
using System.Runtime.InteropServices;

abstract class Animal
{
    //Abstract method(no impliment)
    public abstract void MakeSound();
    public abstract void Color();
   

    //Regular method(has implimentation)
    public void Sleep()
    {
        Console.WriteLine("This animal is sleeping");
    }

    //Child class
    class Dog : Animal
    {
        //Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
        public override void Color()
        {
            Console.WriteLine("Black");
        }
        
    }

    class Cat : Animal
    {
        //Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Cat mew");
        }
        public override void Color()
        {
            Console.WriteLine("White");
        }

    }

    //Using the classes
    class Program
    {
        static void Main()
        {
            Animal myDog = new Dog();
            myDog.MakeSound();
            myDog.Sleep();
            myDog.Color();

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();
            myCat.Color();
        }
    }
}



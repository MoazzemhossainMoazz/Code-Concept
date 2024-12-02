//Abstact class
abstract class Animal
{
    //Abstract method(no impliment)
    public abstract void MakeSound();

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
    }

    class Cat : Animal
    {
        //Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Cat mew");
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

            Animal myCat = new Cat();
            myCat.MakeSound();
            myCat.Sleep();
        }
    }
}
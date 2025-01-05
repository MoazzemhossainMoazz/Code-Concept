class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("Animal make a sound.");
    }
}

class Dog : Animal
{
    public override void speak()
    {
        Console.WriteLine("dog barks.");
    }
}

class Cat : Animal
{
    public override void speak()
    {
        Console.WriteLine("cat Mews.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.speak();
        myCat.speak();
        myDog.speak();
    }
}

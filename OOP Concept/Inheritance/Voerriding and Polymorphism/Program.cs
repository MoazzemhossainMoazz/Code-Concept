class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("This animal make a sound.");
    }
}

class Dig: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat mew");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        myAnimal.MakeSound();

        Cat myCat = new Cat();
        myCat.MakeSound();
    }
}



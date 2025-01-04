

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The make sound.");
    }
}

class Cow : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cow say: Hamba");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: Mew Mew");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Animal myAnimal = new Animal();
        Animal myCow = new Cow();
        Animal myCat = new Cat();

        //Animal myAnimal = new Animal();
        //Cow myHorse = new Cow();
        //Cat myCat = new Cat();

        myAnimal.animalSound();
        myCat.animalSound();
        myCow.animalSound();
    }
}
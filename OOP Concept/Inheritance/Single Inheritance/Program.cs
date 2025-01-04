class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal easts food.");
    }
}

class Cat : Animal
{
    public void Sound()
    {
        Console.WriteLine("The cat sounds Mew Mew");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        myAnimal.Eat();
        //myCat.Sound();


        Cat myCat = new Cat();
        myCat.Eat();
        myCat.Sound();

    }
}

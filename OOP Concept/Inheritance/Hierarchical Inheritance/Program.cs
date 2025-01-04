class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal eat food.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog bark.");
    }
}

class Cat : Animal
{
    public void Mew()
    {
        Console.WriteLine("The cat mews.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        myDog.Eat();
        myDog.Bark();

        myCat.Eat();
        myCat.Mew();
    }
}
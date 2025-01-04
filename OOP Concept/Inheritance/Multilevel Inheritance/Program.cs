//class Animal
//{
//    public void Eat()
//    {
//        Console.WriteLine("The animal eats food");
//    }
//}

//class Cat : Animal
//{
//    public void Sound()
//    {
//        Console.WriteLine("Cat sound Mew mew.");
//    }
//}

//class Dog : Animal
//{
//    public void Sound()
//    {
//        Console.WriteLine("Dog sound Bark");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal myAnimal = new Animal();
//        myAnimal.Eat();

//        Dog myDog = new Dog();
//        myDog.Eat();
//        myDog.Sound();
//    }
//}



class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal eat food.");
    }
}

class Cat : Animal
{
    public void Sound()
    {
        Console.WriteLine("The animal make sound.");
    }
}

class Dog : Cat
{
    public void Color()
    {
        Console.WriteLine("The cat color is black");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Cat Object:");
        Cat myCat = new Cat();
        myCat.Eat();
        myCat.Sound();

        Console.WriteLine("\nDog Object:");
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Sound();
        myDog.Color();
    }
}
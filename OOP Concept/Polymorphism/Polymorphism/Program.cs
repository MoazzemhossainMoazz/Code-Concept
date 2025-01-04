
class Animal           //Base Class(Parent)
{
    public void animalSound()
    {
        Console.WriteLine("The animal make a sound.");
    }
}

class Pig : Animal          //Derived class(Child)
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal          //Derived class(child)
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal hisAnimal = new Animal();    //Animal object
        Animal hisPig = new Animal();       //Pig object
        Animal hisDog = new Animal();       //Dog object

        hisAnimal.animalSound();
        hisPig.animalSound();
        hisDog.animalSound();
    }
}
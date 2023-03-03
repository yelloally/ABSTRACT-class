using System;

//abstract class which represents a method
abstract class Animal
{
    // Abstract method returns 
    public abstract void makeSound();
}

//inheritance
class Dog : Animal
{
    private string breed;

    public Dog(string breed)
    {
        this.breed = breed;
    }

    //override method 
    public override void makeSound()
    {
        Console.WriteLine("The " + breed + " dog says woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What breed is your dog?");
        string breed = Console.ReadLine();

        Animal myAnimal = new Dog(breed);

        myAnimal.makeSound();

        Console.ReadKey();
    }
}

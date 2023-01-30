using Animal.Models;

namespace Animal
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            
            Console.WriteLine(cat.Sound());
            Console.WriteLine(dog.Sound());
        }
    }
}
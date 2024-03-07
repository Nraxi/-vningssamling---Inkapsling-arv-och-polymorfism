using Övningssamling___Inkapsling__arv_och_polymorfism;

namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //var wolf = new Wolf("karl", 77, 89);

            //Console.WriteLine(wolf);

            Animal wolf = new Wolf("BITE", 50, 5);
            Console.WriteLine($"Varg Name: {wolf.Name}, Weight: {wolf.Weight}kg, Age: {wolf.Age}");

            Animal dog = new Dog("Rex", 25, 3);
            Console.WriteLine($"Hund Name: {dog.Name}, Weight: {dog.Weight}kg, Age: {dog.Age}");

            List<Animal> animals = new List<Animal>
            {
                new Horse("Thunder", 300, 8),
                new Dog("Buddy", 20, 4),
                new Hedgehog("Sonic", 2, 1),
                new Worm("Slime", 0.1, 1),
                new Bird("Eagle", 5, 2),
                new Wolf("Howler", 60, 6)
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Weight: {animal.Weight}kg, Age: {animal.Age}");

                if (animal is Bird bird)
                {
                    Console.WriteLine($"Can Fly: {bird.CanFly}");
                }
            }

        }
    }
}

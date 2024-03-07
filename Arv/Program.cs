using Arv;
using System.Drawing;

namespace Arv
{
    //I denna fil ligger även 3.4) Mer polymorfism
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal wolf = new Wolf("BITE", 50, 5);

            if (wolf is Wolf)
            {
                Wolf wolfObject = (Wolf)wolf;
                Console.WriteLine($"Varg Name: {wolf.Name}, Weight: {wolf.Weight}kg, Age: {wolf.Age}, Wolf Color:{wolfObject.Color}");
            }
          
           


            // CREATE a list where all the animals are
            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse("Bella", 500, 7));
            animals.Add(new Dog("Max", 25, 3));
            //animals.Add(new Dog("mimmi", 35, 5));
            //animals.Add(new Hedgehog("Sonic", 1, 2));
            //animals.Add(new Wolf("Alpha", 70, 5, "Grey"));
            //animals.Add(new Pelican("Peli", 10, 1, 3));
            //animals.Add(new Flamingo("Flamy", 5, 2));
            //animals.Add(new Swan("Swanny", 8, 3));
            animals.Add(new Worm("Wormy", 0.01, 1));

            foreach (var animal in animals)
            {
               
                animal.DoSound(); // Anropa djurets ljud
                if (animal is IPerson) // Kontrollera om djuret är också en person
                {
                    IPerson personAnimal = (IPerson)animal; // Typomvandling till IPerson
                    personAnimal.Talk(); // Anropa Talk() metoden
                }
                Console.WriteLine($"Animal: {animal}");
                Console.WriteLine($"Animal name: {animal.Name}");
                Console.WriteLine($"Animal weight: {animal.Weight}");
                Console.WriteLine($"Animal age: {animal.Age}");
            }
            // Skapa en lista för hundar
            List<Dog> Dogs = new List<Dog>();
            Dogs.Add(new Dog("Rex", 30, 4)); 
            Dogs.Add(new Dog("Buddy", 20, 2));

            //9. Det funkar inte för att det är inte rätt Typ. För listan förväntar sig att det
            // kommer ifrån dog eller någon av deras under classer. Därav varför det inte går. 
            //10. Om de ska lagras tillsammans ska de ligga under listan animals istället. Se ovan.Iomed att alla klasser ärver ifrån animals. 
            Console.WriteLine("NR.11");
            foreach (var animal in animals)
            {
                Console.Write(" ");
                Console.WriteLine(animal.Stats());
            }
            Console.WriteLine("\nNR.13");
            Console.WriteLine("Loopen i detta fall itteriar över varje djur i listan som vi har angett och skriver ut deras egna attribute ROAR exmpl");

            Console.WriteLine("\nSkriv ut alla hundar i animals ");
            foreach (var animal in animals)
            {
                if (animal is Dog)
                Console.WriteLine($"Hund:{animal.Stats()} ");
                
            }
            Console.WriteLine("\n");
            foreach (var animal in animals) //OBS iomed att vi renderar ifrån animals så om vi lägger in fler hunda kommer vi få fler svar. 
            {
                if (animal is Dog) // vi kontorllerar ifall det aktuella djuret är en instans av klassen dog
                {
                    Dog dog = (Dog)animal; // Gör en typkonvertering till Dog
                    Console.WriteLine(dog.NewStringClass());
                }
            }
            // 16/17. Nej, Anledningen till det är att NewStringClass metoden är en metod spcefikt för Dog klassen och inte från basklassen animal. Därav varför jag måste typ konverera den för att den ska leta i rätt fält. 
        }
    }
}

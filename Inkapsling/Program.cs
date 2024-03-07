namespace Inkapsling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    // create a mandalorian bounty hunter
            //    Person person = new Person(10, "jango", "fett");

            //    Person.Height = 183;
            //    Person.Weight = 79;

            //    Console.WriteLine(person);
            //    Console.WriteLine("person created successfully.");

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"error: {ex.Message}");
            //}

            try
            {
                PersonHandler handler = new PersonHandler();

                // Create a Jedi
                Person person = handler.CreatePerson(21, "Anakin", "Skywalker", 188, 84);
                Person person2 = handler.CreatePerson(25, "Padme", "Skywalker", 165, 45);
                // handler.SetAge(person, 25);

                Console.WriteLine("Jedi was created:");
                Console.WriteLine($"Name: {person.FName} {person.LName}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Height: {person.Height} cm");
                Console.WriteLine($"Weight: {person.Weight} kg");
                Console.WriteLine($"Person: {person}");
                Console.WriteLine($"Person: {person2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    }


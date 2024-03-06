namespace Övningssamling___Inkapsling__arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Create a Mandalorian Bounty Hunter
            //    Person person = new Person(10, "Jango", "Fett");
            //    person.Height = 183;
            //    person.Weight = 79;

            //    Console.WriteLine("Person created successfully.");
            //    Console.WriteLine(person); 
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            try
            {
                PersonHandler handler = new PersonHandler();

                //Create a  JEDI
                Person person = handler.CreatePerson(21, "Anakin", "Skywalker", 188, 84);

                //  handler.SetAge(person, 25);

                Console.WriteLine("Jedi was created:");
                Console.WriteLine($"Name: {person.FName} {person.LName}");
                Console.WriteLine($"Age: {person.Age}");
                Console.WriteLine($"Height: {person.Height} cm");
                Console.WriteLine($"Weight: {person.Weight} kg");
            }
            catch (ArgumentException ex) { Console.WriteLine($"Error: {ex.Message}"); }
        }
    }
}

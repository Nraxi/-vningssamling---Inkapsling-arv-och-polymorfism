namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(), new TextInputError()
            };

            List<UserError> Starwars = new List<UserError>
            {
                new Mandalorians(),
                new Jedi(),
                new BountyHunter()
            };

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
            foreach (var e in Starwars)
            {
                Console.WriteLine(e.UEMessage());
            }
        }
    }
}

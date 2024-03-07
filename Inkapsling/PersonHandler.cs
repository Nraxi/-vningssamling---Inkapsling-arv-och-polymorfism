namespace Inkapsling
{
    //inkapsling
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person(age, fName, lName);
            person.Height = height;
            person.Weight = weight;
            return person;
        }
    }
}

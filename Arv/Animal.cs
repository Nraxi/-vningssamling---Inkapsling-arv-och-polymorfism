using System.Drawing;

namespace Övningssamling___Inkapsling__arv_och_polymorfism
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();
        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
        //public override string ToString()
        //{
        //    return $"{Name},{Weight},{Age}";
        //}
    }
    public class Horse : Animal
    {  
        public string Smart { get; set; }
        public Horse(string name, double weight, int age) : base(name, weight, age) 
        { Smart = "sometimes"; }
        public override void DoSound()
        {
            Console.WriteLine("Horse sounds: Neigh!");
        }
    }
    public class Dog : Animal
    {
        public bool CanBark { get; set; }
        public Dog(string name, double weight, int age) : base(name, weight, age) 
        { CanBark = true; }
        public override void DoSound()
        {
            Console.WriteLine("Dog sounds: VOFF!");
        }
    }
    public class Hedgehog : Animal
    {
        public bool HaveSpikes { get; set; }
        public Hedgehog(string name, double weight, int age) : base(name, weight, age)
        {
            HaveSpikes = true;
        }
        public override void DoSound()
        {
            Console.WriteLine("Hedgehog sounds: ihhh!");
        }
    }
    public class Worm : Animal
    {
        public string posion { get; set; }
        public Worm(string name, double weight, int age) : base(name, weight, age)
        { posion = "is toxic"; }
        public override void DoSound()
        {
            Console.WriteLine("Worm sounds: sllr!");
        }
    }
    public class Bird : Animal
    {
        public bool CanFly { get; set; }
        public Bird(string name, double weight, int age) : base(name, weight, age)
        {
            CanFly = true;
        }
        public override void DoSound()
        {
            Console.WriteLine("Bird sounds: kvack!");
        }
    }
    public class Wolf : Animal
    {
        public string Color { get; set; }
        public Wolf(string name, double weight, int age, string color = "Brown Red") : base(name, weight, age)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Wolf sounds: ahooooo!");
        }

        // public override string ToString()
        //{
        //    return $"{Name},{Weight},{Age},{Color}";
        //}
    }

    public class Pelican : Bird
    {
        public int FeetSize { get; set; }
        public Pelican(string name, double weight, int age, int feetsize) : base(name, weight, age) 
        {
            FeetSize = feetsize;
        }
        public override void DoSound()
        {
            Console.WriteLine("Pelican sounds: Squawk!");
        }
    }

    public class Flamingo : Bird
    {
        public string Color { get; set; }
        public Flamingo(string name, double weight, int age, string color = "pink") : base(name, weight, age)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("Flamingo sounds: Squawk!");
        }
    }

    public class Swan : Bird
    {
        public bool Arewhite { get; set; }
        public Swan(string name, double weight, int age, bool arewhite = true) : base(name, weight, age)
        {
            Arewhite = arewhite;
        }
        public override void DoSound()
        {
            Console.WriteLine("Swan sounds: Squawk!");
        }
    }
    public interface IPerson
    {
        void Talk();
    }
    
}

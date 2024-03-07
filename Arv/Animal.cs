using System.Drawing;

namespace Arv
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

        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }
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
        public override string Stats()
        {
            return $"{base.Stats()}, Smart: {Smart}";
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
        public override string Stats()
        {
            return $"{base.Stats()}, Can Bark: {CanBark}";
        }

        public string NewStringClass()
        {
            return "THElluuu.";
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
            Console.WriteLine("Hedgehog sounds: ihhhhhhhhh!");
        }
        public override string Stats()
        {
            return $"{base.Stats()}, Have spikes: {HaveSpikes}";
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
        public override string Stats()
        {
            return $"{base.Stats()}, worm have posion: {posion}";
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

        public override string Stats()
        {
            return $"{base.Stats()}, Can bird fly?: {CanFly}";
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

     
        public override string Stats()
        {
            return $"{base.Stats()}, The wolf have: {Color}";
        }
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
        public override string Stats()
        {
            return $"{base.Stats()}, The Pelican have: {FeetSize} in feet";
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
        public override string Stats()
        {
            return $"{base.Stats()}, The Flamingo have: {Color} feathers";
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
        public override string Stats()
        {
            return $"{base.Stats()}, are Swans white?: {Arewhite} ";
        }
    }
    public interface IPerson
    {
        void Talk();
    }
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string color = "Brown Red") : base(name, weight, age, color)
        { }
        public void Talk()
        {
            Console.WriteLine("wof");
        }

      //13. Då kan vi lägga det under Bird, iomed att vi även har fåglar redan där. Annars får vi skapa en ny parent class och lägga det där. 
      //14. Om vi ska göra fler djur eller liknade så är det bra att lägga det under animal då vi redan har det som parent och det e dumt att lägga till repeat kod. Såvidare vi inte ska skapa en ny klass som tex däggdjur och lägga allt där under.

    }
}

﻿namespace Inkapsling
{
    //Inkapsling
    public class Person
    {
        private int age;
        private string? fName;
        private string? lName;
        //private double height;
        //private double weight;




        public double Height { get; set; }
        public double Weight { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater then 0");
                }
            }
        }


        public string? FName
        {
            get { return fName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First name must betweeb 2 and 10 char long");
                }
            }
        }


        public string? LName
        {
            get { return lName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Last name must be between 3 and 15 char long");
                }
            }
        }


        public Person(int age, string fName, string lName)
        {
            Age = age;
            FName = fName;
            LName = lName;
        }
        public override string ToString()
        {
            return $"Age: {Age}, First Name: {FName}, Last Name: {LName}, Height: {Height} cm, Weight: {Weight} kg";
        }
    }


}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Color
    {
        public float r, g, b;
    }

    class Dog
    {
        public string name;
        public int age;
        public string breed;
        public Color color;

        public void Speak()
        {
            Console.WriteLine(name + " is barking");
        }
        public void Walk()
        {
            Console.WriteLine(name + " is walking");
        }
        public void Sit()
        {
            Console.WriteLine(name + " is ssitting ");
        }
        public void WagTail()
        {
            Console.WriteLine(name + " is wagingit's tail");
        }

        // Extra 
        public void GetInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Breed: " + breed);
            Console.WriteLine("Color: r- " + color +
                                    " g- " +
                                    " b- ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color();
            red.r = 1;
            red.g = 0;
            red.b = 0;

            //Create new instance of Dog
            Dog dog1 = new Dog();
            dog1.name = "lassie";
            dog1.breed = "Corgie";
            dog1.age = 1;
            dog1.color = red;

            dog1.Speak();
            dog1.Walk();

            Console.ReadLine();
        }
    }
}

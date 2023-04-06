// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World!");
            Console.WriteLine("Code pushing from 2nd Developer");
            Console.WriteLine("Modifying in local repository");
            Console.WriteLine("Modifying code from remote repository");

            //object or instance syntax
            //ClassName variable=new ClassName();
            Human human = new Human();
            //display msg on output screen
            Console.WriteLine("Please enter human name");
            human.name = Console.ReadLine();
            //reading input from output screen
            Console.WriteLine("Please enter your height");
            human.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            human.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your age");
            human.age = Convert.ToInt32(Console.ReadLine());
            human.Speak();
            human.HumanDetails(human.name, human.height, human.weight, human.age);
            Console.ReadLine();

        }
    }
}


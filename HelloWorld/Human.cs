using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Human
    {
        //instance variables
        //name,height,weight,age
        //syntax - accessmodifier datatype variable
        public string name;
        public float height, weight;
        public int age;

        //instance 
        public void Speak() //method definition/signature
        {
            //method body or implementation
            Console.WriteLine("Human can Speak");
        }

        //instance
        public void HumanDetails(string humanName, float humanHeight, float humanWeight, int age) //mwthod definition/signature
        {
            //method body or implementation
            Console.WriteLine("Human Details:{0} {1} {2} {3}", humanName, humanHeight, humanWeight, age);
        }
    }
}

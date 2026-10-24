using System.Runtime.InteropServices.JavaScript;
using System.Runtime.InteropServices.Swift;

namespace Inheritance_Intro
{
    public class Person
    {
        private int id;
        private string name;
        private int age;
        protected double height; //  units: cm
        private double weight; // private - only inside the class | protected - available to all the hierarchy;

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = new string(name);
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        protected double GetWeight()
        {
            return this.weight;
        }
    }
}

    

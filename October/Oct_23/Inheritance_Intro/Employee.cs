namespace Inheritance_Intro
{
    public class Employee : Person
    {
        private string proffesion;
        private double salary;
        
        public Employee(int id, string name, int age, string proffesion, double salary) : base(id, name, age)
        {
            this.proffesion = proffesion;
            this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary;
        }
    }
}
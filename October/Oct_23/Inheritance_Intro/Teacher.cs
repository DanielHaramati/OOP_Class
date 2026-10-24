namespace Inheritance_Intro
{
    public class Teacher : Employee
    {
        public Teacher(int id, string name, int age, string proffesion, double salary) : base(id, name, age, proffesion,
            salary)
        {
            
        }
    }
}
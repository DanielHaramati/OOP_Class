
namespace Inheritance_Intro
{
    class Program
    {


        static void Main(string[] args)
        {
            Person p1 = new Person(1, "shalom", 70);
        
            Employee e1 = new Employee(2, "rivka", 45, "Teacher", 12000);
            
            Console.WriteLine(e1.GetName());

            Teacher t1 = new Teacher(3, "Daniel", 62, "Teacher", 20000);

            Console.WriteLine(t1.GetName());
            Console.WriteLine(t1.GetSalary());


            Student st1 = new Student(18, "dor", 16, 11, "1234");
            Console.WriteLine(st1.GetStudentWeight());
        }
        
    }
}
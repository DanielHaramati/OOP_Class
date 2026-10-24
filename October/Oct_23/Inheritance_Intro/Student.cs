namespace Inheritance_Intro
{

    public class Student : Person
    {
        private int year;
        private string student_id;
        
        
        public Student(int id, string name, int age, int year, string student_id) : base(id, name, age)
        {
            this.year = year;
            this.student_id = student_id;
        }

        public double GetStudentWeight()
        {
            return this.GetWeight();
        }
        
        
        
        
        
        
        public string DescribeStudent()
        {
            string st = "";
            
            st += this.student_id + "\n";
            st += this.year + "\n";
            st += this.GetName() + "\n";
            st += this.height;

            return st;
        }
    }

}
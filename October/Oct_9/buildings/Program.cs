namespace Buildings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Room r1 = new Room(1,2,"h");
            System.Console.WriteLine(r1.GetLength());
        }
    }
}
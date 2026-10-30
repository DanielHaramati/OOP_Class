namespace _2nd_exercise;

class Program
{
    static void Main(string[] args)
    {
        Line l1 = new Line(67, "HaShalom", "Merkazit", 4);
        Console.WriteLine(l1 + "\n");
        BusLine bl1 = new BusLine(55, "MerkazitOno", "Savidor", 4, 55);
        Console.WriteLine(bl1 + "\n");
    }
}
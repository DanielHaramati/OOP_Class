namespace CompositeObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train t1 = new Train(new Engine(100, 2025)); 
            bool res = t1.AddCarriage(new Carriage(12, 52));
            Console.WriteLine($"max passengers: is {t1.MaxTrainPassengars()}");
            Console.WriteLine($"total active passengers: {t1.Average_active_passangers_carriages()}");
        }


        
    }
}
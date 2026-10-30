namespace _2nd_exercise;

public class RegularBusLine : BusLine
{

    private int[] stops;
    
    
    public RegularBusLine(int stops_num, int lineNumber, string origin, string destination, double price, int passangers, int[] stops)
        : base(lineNumber, origin, destination, price,passangers)
    {
        this.stops = stops;
    }


    public override string ToString()
    {
        return base.ToString() + $"stops amount is {this.stops}";
    }
}
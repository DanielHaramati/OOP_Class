namespace _2nd_exercise;

public class BusLine : Line
{
    private int passangers;

    public BusLine(int lineNumber, string origin, string destination, double price, int passangers)
        : base(lineNumber, origin, destination, price)
    {
        this.passangers = passangers;
    }

    public void ChangePassangers(int num) // + for more, - for less
    {
        this.passangers += num;
    }

    public override string ToString()
    {
        return base.ToString() + $"\npassanger amount is: {this.passangers}"; 
    }
}
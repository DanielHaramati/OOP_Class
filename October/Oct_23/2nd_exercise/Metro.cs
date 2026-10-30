namespace _2nd_exercise;

public class Metro : Line
{
    private int carrriageAmount;

    public Metro(int lineNumber, string origin, string destination, double price, int carriageAmount)
        : base(lineNumber, origin, destination, price)
    {
        this.carrriageAmount = carriageAmount;
    }

    public void SetCarriageAmount(int amount)
    {
        this.carrriageAmount = amount;
    }
}
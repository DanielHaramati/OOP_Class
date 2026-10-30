using System.Runtime.CompilerServices;

namespace _2nd_exercise;

public class Line
{
    private int lineNumber;
    private string origin;
    private string destination;
    private double price;
    
    
    public Line(int lineNumber, string origin, string destination, double price)
    {
        this.lineNumber = lineNumber;
        this.origin = origin;
        this.destination = destination;
        this.price = price;
    }
    
    public void SetLineNumber(int lineNumber) // can change line number to the another number
    {
        this.lineNumber = lineNumber;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }
    
    public bool IsConnect(Line otherLine) // last stop is another line start stop
    {
        return this.destination.Equals(otherLine.origin);
    }

    public override string ToString()
    {
        return $"line number: {this.lineNumber}" +
               $"origin: {this.origin}" +
               $"destination: {this.destination}";
    }
}
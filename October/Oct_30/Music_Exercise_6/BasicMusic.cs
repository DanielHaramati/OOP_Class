namespace Music_Exercise_6;

public class BasicMusic
{
    private string creationName;
    private double listeningMinutes;
    private double downloadPrice;

    public BasicMusic(string creationName, double listeningMinutes, double downloadPrice)
    {
        this.creationName = creationName;
        this.listeningMinutes = listeningMinutes;
        this.downloadPrice = downloadPrice;
    }

    public double GetTime()
    {
        return this.listeningMinutes;
    }

    public double GetPrice()
    {
        return this.downloadPrice;
    }
}
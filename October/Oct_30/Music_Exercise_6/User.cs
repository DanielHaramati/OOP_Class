namespace Music_Exercise_6;

public class User
{
    private string subscriberName;
    private Disk[] disksArr;
    private int diskAmount;
    private int index;
    
    public User(string subscriberName, int diskAmount)
    {
        this.subscriberName = subscriberName;
        this.disksArr = new Disk[diskAmount];
        this.diskAmount = 0;
    }

    public void Add(Disk d)
    {
        if (this.index >= this.diskAmount)
        {
            Console.WriteLine("cant put any more disks !");
            return;
        }
        this.disksArr[this.index] = d;
        this.diskAmount += 1;
    }

    public double Payment()
    {
        double totalPrice = 0;
        for (int i = 0; i <= index; i++)
        {
            totalPrice += this.disksArr[i].Total_Price();
        }

        return totalPrice;
    }
}
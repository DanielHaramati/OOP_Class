namespace Music_Exercise_6;

public class Disk
{
    private string diskName;
    private Song[] songsArr;
    private string publishDate;
    
    public Disk(string diskName, string publishDate, int songsNum)
    {
        this.diskName = diskName;
        this.publishDate = publishDate;
        this.songsArr = new Song[songsNum];
        
    }

    public double Time() // returns total songs time
    {
        double totalMinutes = 0;
        for (int i = 0; i < this.songsArr.Length; i++)
        {
            totalMinutes += this.songsArr[i].GetTime();
        }

        return totalMinutes;
    }

    public double Total_Price()
    {
        double amount = 0;
        for (int i = 0; i < this.songsArr.Length; i++)
        {
            amount += songsArr[i].GetPrice();
        }

        return amount;
    }
    
}
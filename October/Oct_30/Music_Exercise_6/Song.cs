namespace Music_Exercise_6;

public class Song : BasicMusic
{
    private string performerName;
    private string authorName;
    private string composerName;
    
    public Song(string creationName, double listeningMinutes, double downloadPrice,
        string performerName, string authorName, string composerName) 
        : base(creationName, listeningMinutes, downloadPrice)
    {
        this.performerName = performerName;
        this.authorName = authorName;
        this.composerName = composerName;
    }
    
}
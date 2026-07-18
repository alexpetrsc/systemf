public class MusicFile
{
    public string Title { get; }

    public string Artist { get; }

    public string Album { get; }

    public MusicFile(
        string title,
        string artist,
        string album)
    {
        Title = title;
        Artist = artist;
        Album = album;
    }
}

using System.Collections.Generic;

public class Artist
{
    public string Name { get; }

    public List<MusicFile> Tracks { get; } = new();

    public Artist(string name)
    {
        Name = name;
    }
}

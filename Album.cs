using System.Collections.Generic;

public class Album
{
    public string Name { get; }

    public List<MusicFile> Tracks { get; } = new();

    public Album(string name)
    {
        Name = name;
    }
}

using System.Collections.Generic;

public class MusicLibrary
{
    public List<MusicFile> Tracks { get; }

    public MusicLibrary(
        List<MusicFile> tracks)
    {
        Tracks = tracks;
    }
}

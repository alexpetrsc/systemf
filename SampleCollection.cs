using System.Collections.Generic;

public static class SampleCollection
{
    public static List<MusicFile> Load()
    {
        return new()
        {
            new MusicFile(
                "One More Time",
                "Daft Punk",
                "Discovery"
            ),

            new MusicFile(
                "Get Lucky",
                "Daft Punk",
                "Random Access Memories"
            ),

            new MusicFile(
                "Another Brick In The Wall",
                "Pink Floyd",
                "The Wall"
            ),

            new MusicFile(
                "Comfortably Numb",
                "Pink Floyd",
                "The Wall"
            ),

            new MusicFile(
                "Hysteria",
                "Muse",
                "Absolution"
            )
        };
    }
}

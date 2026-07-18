using System.Linq;

public class StatisticsBuilder
{
    public int ArtistCount(
        MusicLibrary library)
    {
        return library.Tracks
            .Select(t => t.Artist)
            .Distinct()
            .Count();
    }

    public int AlbumCount(
        MusicLibrary library)
    {
        return library.Tracks
            .Select(t => t.Album)
            .Distinct()
            .Count();
    }
}

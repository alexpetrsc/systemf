using System;
using System.Linq;

public static class ConsoleReport
{
    public static void Print(
        MusicLibrary library)
    {
        Console.WriteLine(
            "Scanning Music Library...\n"
        );

        Console.WriteLine("Artists\n");

        foreach (var artist in library.Tracks
                     .GroupBy(t => t.Artist))
        {
            Console.WriteLine(
                artist.Key
            );

            Console.WriteLine(
                $"{artist.Count()} tracks\n"
            );
        }

        Console.WriteLine("-------------------------\n");

        Console.WriteLine("Albums\n");

        foreach (var album in library.Tracks
                     .Select(t => t.Album)
                     .Distinct())
        {
            Console.WriteLine(album);
        }

        Console.WriteLine();

        var stats =
            new StatisticsBuilder();

        Console.WriteLine(
            $"Tracks indexed : {library.Tracks.Count}"
        );

        Console.WriteLine(
            $"Artists : {stats.ArtistCount(library)}"
        );

        Console.WriteLine(
            $"Albums : {stats.AlbumCount(library)}"
        );
    }
}

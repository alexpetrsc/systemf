public class LibraryScanner
{
    public MusicLibrary Scan()
    {
        return new MusicLibrary(
            SampleCollection.Load()
        );
    }
}

# Music Library Catalog

A console application that scans a local music collection and builds a summary by artists and albums.

The demo version uses sample music files stored in memory, but the architecture is prepared for real folder scanning.

---

## Console Example

```
Scanning Music Library...

Artists

Daft Punk
2 tracks

Pink Floyd
2 tracks

Muse
1 track

-------------------------

Albums

Discovery
Random Access Memories
The Wall
Absolution

Tracks indexed : 5
Artists : 3
Albums : 4
```

---

## Components

LibraryScanner.cs
Scans folders.

MusicLibrary.cs
Stores indexed tracks.

StatisticsBuilder.cs
Calculates totals.

ConsoleReport.cs
Displays results.

SampleCollection.cs
Provides demo files.

---

Run

```
dotnet run
```

.NET 8 Console Application.

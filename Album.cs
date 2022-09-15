namespace albumApi;

public class Album
{
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public Artist Artist { get; set; } = new Artist();
    public Track[] TrackListing { get; set; } = Array.Empty<Track>();
    public string? Art { get; set; }

}
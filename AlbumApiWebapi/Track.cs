namespace albumApi;

public class Track
{
    public string Name { get; set; } = string.Empty;
    public decimal Duration { get; set; }
    public Artist[] Features { get; set; } = Array.Empty<Artist>();
    public Artist[] Producers { get; set; } = Array.Empty<Artist>();
}
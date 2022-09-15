namespace albumApi;

public class Artist
{
    public string stageName { get; set; } = string.Empty;
    public string? governmentName { get; set; }
    public string? website { get; set; }
    public string? profile { get; set; }

    public Artist()
    {
        this.governmentName = string.Empty;
        this.website = string.Empty;
        this.profile = string.Empty;
    }
}
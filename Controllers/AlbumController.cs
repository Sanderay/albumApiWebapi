using Microsoft.AspNetCore.Mvc;

namespace albumApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumController : ControllerBase
{
    private Album[] _albums;
    private Album _paragonOfDopeness;
    private Album _dreamin;
    private Artist _artist;
    private Track _trackOne;
    private Track _trackTwo;
    private Track _trackThree;
    private Track _trackFour;

    public AlbumController()
    {
        _artist = new Artist
        {
            stageName = "RVS",
        };

        _trackOne = new Track
        {
            Name = "Track One",
            Duration = 126.6M,
        };

        _trackTwo = new Track
        {
            Name = "Track Two",
            Duration = 360.8M,
        };

        _trackThree = new Track
        {
            Name = "Track Three",
            Duration = 360.8M,
        };

        _trackFour = new Track
        {
            Name = "Track Four",
            Duration = 360.8M,
        };

        _paragonOfDopeness = new Album
        {
            Title = "Paragon of Dopeness",
            ReleaseDate = DateTime.Now,
            Artist = _artist,
            TrackListing = new Track[]
            {
                _trackOne, _trackTwo
            },
            Art = "https://f4.bcbits.com/img/a1537471093_10.jpg"
        };

        _dreamin = new Album
        {
            Title = "Dreamin",
            ReleaseDate = DateTime.Now,
            Artist = _artist,
            TrackListing = new Track[]
            {
                _trackThree, _trackFour
            }
        };

        _albums = new Album[2]
        {
            _paragonOfDopeness, _dreamin
        };


    }

    [HttpGet(Name = "Album")]
    public IEnumerable<Album> Get()
    {
        return _albums;
    }
}

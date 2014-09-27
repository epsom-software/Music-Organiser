using System.Collections.Generic;

namespace MusicOrganiser.Web.Models
{
    /// <summary>
    /// A super simple stub repository
    /// </summary>
    public class SongsRepository
    {
        public List<Song> Songs = new List<Song>{
            new Song {
                Id = 1,
                Title = "1984",
                Album = "Diamond Dogs",
                Artist = "David Bowie",
            },
            new Song {
                Id = 2,
                Title = "Suffragette City",
                Album = "The Rise and Fall of Ziggy Stardust and the Spiders from Mars",
                Artist = "David Bowie",
            },
            new Song {
                Id = 3,
                Title = "The Man Who Sold the World",
                Album = "The Man Who Sold the World",
                Artist = "David Bowie",
            },
        };
    }
}
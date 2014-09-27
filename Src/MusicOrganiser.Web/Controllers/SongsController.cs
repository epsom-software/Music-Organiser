using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Http;
using MusicOrganiser.Web.Models;

namespace MusicOrganiser.Web.Controllers
{
    /// <summary>
    /// A super simple songs api, which will temporarily store some songs in memory
    /// </summary>
    public class SongsController : ApiController
    {
        private static SongsRepository SongsRepository = new SongsRepository();

        public IEnumerable<Song> Get()
        {
            Thread.Sleep(1000);
            return SongsRepository.Songs;
        }

        public Song Get(int id)
        {
            Thread.Sleep(1000);
            return SongsRepository.Songs.FirstOrDefault(s => s.Id == id);
        }

        public void Post([FromBody]Song value)
        {
            Thread.Sleep(1000);
            SongsRepository.Songs.Add(value);
        }

        public void Put(int id, [FromBody]Song value)
        {
            Thread.Sleep(1000);
            int index = SongsRepository.Songs.FindIndex(s => s.Id == value.Id);

            if (index < 0)
            {
                SongsRepository.Songs.Add(value);
            }
            else
            {
                SongsRepository.Songs[index] = value;
            }
        }

        public void Delete(int id)
        {
            Thread.Sleep(1000);
            int index = SongsRepository.Songs.RemoveAll(s => s.Id == id);
        }
    }
}

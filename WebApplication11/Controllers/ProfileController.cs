using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using t1.Models;

namespace t1.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        public List<Profile> Get()
        {
            return ProfileDb.Profiles;
        }

        [HttpGet("{id}")]
        public Profile Get(int id)
        {
            return ProfileDb.Profiles.Single(x => x.Id == id);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var victim = ProfileDb.Profiles.Single(x => x.Id == id);
            return ProfileDb.Profiles.Remove(victim);
        }

        [HttpPost]
        public bool Post([FromBody] Profile profile)
        {
            ProfileDb.Profiles.Add(profile);
            return true;
        }
    }
}

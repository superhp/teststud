using System.Collections.Generic;

namespace t1.Models
{
    public static class ProfileDb
    {
        public static List<Profile> Profiles = new List<Profile>(
            new[]
            {
                new Profile { Id = 1, Name = "Tomas", Age = 17 },
                new Profile { Id = 2, Name = "Joana", Age = 46 }
            }
        );
    }
}

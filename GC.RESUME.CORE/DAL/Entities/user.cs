using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class User
    {
        public User()
        {
            Profiles = new HashSet<Profile>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}

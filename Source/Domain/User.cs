using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class User
    {
        public User()
        {
            Roles = new List<Role>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid EmailId { get; set; }

        public virtual Email Email { get; set; }

        public string Password { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class Configuration
    {
        public Configuration()
        {
            Roles = new List<Role>();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
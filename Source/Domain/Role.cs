using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class Role
    {
        public Role()
        {
            Users = new List<User>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Tag { get; set; }

        public string Description { get; set; }

        public Guid ConfigurationId { get; set; }

        public virtual Configuration Configuration { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
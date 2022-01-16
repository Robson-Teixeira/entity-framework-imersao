using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class Organization
    {
        public Organization()
        {
            Franchises = new List<Franchise>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid EmailId { get; set; }

        public virtual Email Email { get; set; }

        public string Image { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<Franchise> Franchises { get; set; }
    }
}
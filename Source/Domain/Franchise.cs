using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class Franchise
    {
        public Franchise()
        {
            Persons = new List<Person>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}
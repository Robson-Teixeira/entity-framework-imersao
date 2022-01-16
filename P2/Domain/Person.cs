using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class Person
    {
        public Person()
        {
            Addresses = new List<Address>();
            Phones = new List<Phone>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid FranchiseId { get; set; }

        public virtual Franchise Franchise { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}
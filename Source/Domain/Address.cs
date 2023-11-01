using System;
using System.Collections.Generic;

namespace P2.Domain
{
    public class Address
    {
        public Address()
        {
            AdditionalInfos = new List<AdditionalInfo>();
        }

        public Guid Id { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public Guid PersonId { get; set; }

        public virtual Person Person { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }

        public virtual ICollection<AdditionalInfo> AdditionalInfos { get; set; }
    }
}
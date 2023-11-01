using System;

namespace P2.Domain
{
    public class AdditionalInfo
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public Guid AddressId { get; set; }

        public virtual Address Address { get; set; }

        public Guid AdditionalInfoDefinitionId { get; set; }

        public virtual AdditionalInfoDefinition AdditionalInfoDefinition { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }
    }
}
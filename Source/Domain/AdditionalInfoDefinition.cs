using System;

namespace P2.Domain
{
    public class AdditionalInfoDefinition
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }
    }
}
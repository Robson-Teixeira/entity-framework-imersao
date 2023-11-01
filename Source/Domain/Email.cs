using System;

namespace P2.Domain
{
    public class Email
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Domain { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }
    }
}
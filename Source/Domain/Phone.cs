using System;

namespace P2.Domain
{
    public class Phone
    {
        public Guid Id { get; set; }

        public int Ddi { get; set; }

        public int Ddd { get; set; }

        public int Number { get; set; }

        public Guid PersonId { get; set; }

        public virtual Person Person { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdateUser { get; set; }
    }
}
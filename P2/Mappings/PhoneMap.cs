using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class PhoneMap : EntityTypeConfiguration<Phone>
    {
        public PhoneMap()
        {
            ToTable("Phone");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Ddi)
                .IsRequired();

            Property(x => x.Ddd)
                .IsRequired();

            Property(x => x.Number)
                .IsRequired();

            HasRequired(x => x.Person)
                .WithMany(x => x.Phones)
                .HasForeignKey(y => y.PersonId);
        }
    }
}
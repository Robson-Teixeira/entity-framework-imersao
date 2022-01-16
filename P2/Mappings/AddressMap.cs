using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("Address");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Street)
                .IsRequired()
                .HasMaxLength(500);

            Property(x => x.Number)
                .IsRequired()
                .HasMaxLength(10);

            Property(x => x.District)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.City)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.State)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(x => x.Person);

            HasMany(x => x.AdditionalInfos)
                .WithRequired(x => x.Address);
        }
    }
}
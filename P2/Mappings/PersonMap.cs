using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("Person");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            HasRequired(x => x.Franchise)
                .WithMany(x => x.Persons)
                .HasForeignKey(y => y.FranchiseId);

            HasRequired(x => x.User);

            HasMany(x => x.Addresses)
                .WithRequired(x => x.Person);

            HasMany(x => x.Phones)
                .WithRequired(x => x.Person);
        }
    }
}
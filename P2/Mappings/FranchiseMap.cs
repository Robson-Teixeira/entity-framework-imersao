using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class FranchiseMap : EntityTypeConfiguration<Franchise>
    {
        public FranchiseMap()
        {
            ToTable("Franchise");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            HasRequired(x => x.Organization)
                .WithMany(x => x.Franchises)
                .HasForeignKey(y => y.OrganizationId);

            HasMany(x => x.Persons)
                .WithRequired(x => x.Franchise);
        }
    }
}
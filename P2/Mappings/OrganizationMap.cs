using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class OrganizationMap : EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            ToTable("Organization");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //Property(x => x.Id).HasColumnName("Id");

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            Property(x => x.Image)
                .IsRequired();

            Property(x => x.IsActive)
                .IsRequired();

            HasRequired(x => x.Email);

            HasMany(x => x.Franchises)
                .WithRequired(x => x.Organization);
        }
    }
}
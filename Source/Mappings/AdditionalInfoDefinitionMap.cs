using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class AdditionalInfoDefinitionMap : EntityTypeConfiguration<AdditionalInfoDefinition>
    {
        public AdditionalInfoDefinitionMap()
        {
            ToTable("AdditionalInfoDefinition");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1024);
        }
    }
}
using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class AdditionalInfoMap : EntityTypeConfiguration<AdditionalInfo>
    {
        public AdditionalInfoMap()
        {
            ToTable("AdditionalInfo");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1024);

            HasRequired(x => x.AdditionalInfoDefinition);
        }
    }
}
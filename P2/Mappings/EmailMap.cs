using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            ToTable("Email");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Domain)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
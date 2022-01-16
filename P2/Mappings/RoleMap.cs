using P2.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace P2.Mappings
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable("Role");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(60);

            Property(x => x.Tag)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1024);

            HasRequired(x => x.Configuration)
                .WithMany(x => x.Roles)
                .HasForeignKey(y => y.ConfigurationId);

            HasMany(x => x.Users)
                .WithMany(x => x.Roles)
                .Map(y =>
                {
                    y.ToTable("UserRoles");
                    y.MapLeftKey("RoleId");
                    y.MapRightKey("UserId");
                });
        }
    }
}
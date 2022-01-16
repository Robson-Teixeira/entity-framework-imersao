using P2.Domain;
using P2.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace P2.DataContext
{
    public class MyDataContext : DbContext
    {
        public MyDataContext()
            : base("MyConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MyDataContext>());
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        #region DbSets
        public DbSet<Franchise> Franchises { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<AdditionalInfo> AdditionalInformations { get; set; }

        public DbSet<AdditionalInfoDefinition> AdditionalInformationDefinitions { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Email> Emails { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Configuration> Configurations { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AdditionalInfoDefinitionMap());
            modelBuilder.Configurations.Add(new AdditionalInfoMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new ConfigurationMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new FranchiseMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PhoneMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
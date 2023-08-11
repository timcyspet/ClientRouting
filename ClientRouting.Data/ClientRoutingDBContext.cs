using ClientRouting.Model;
using Microsoft.EntityFrameworkCore;

namespace ClientRouting.Data
{
    public class ClientRoutingDBContext :DbContext
    {
        public ClientRoutingDBContext(DbContextOptions optionsBuilder)
        : base(optionsBuilder)
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
            //this.Database.CommandTimeout = 180;
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientResource> ClientResources { get; set; }
        public DbSet<ResourceType> ResourceTypes { get; set; }
        public DbSet<ResourceConfiguration> ResourceConfigurations { get; set; }
        public DbSet<ConfigurationProperty> ConfigurationProperties { get; set; }
        public DbSet<ResourceTemplate> ResourceTemplates { get; set; }
        public DbSet<ClientEngagement> ClientEngagements { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<ClientTemmpalte> ClientTemmpaltes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Jurisdiction> Jurisdictions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ClientProperty> ClientProperties { get; set; }
        public DbSet<ClientCustomProperty> ClientCustomProperties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database provider and connection string
            //optionsBuilder.UseSqlServer(System.Configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Client");
            base.OnModelCreating(modelBuilder);
        }
    }
}
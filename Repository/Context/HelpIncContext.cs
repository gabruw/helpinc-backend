using Domain.Entity;
using Repository.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Repository.Context
{
    public class HelpIncContext : IdentityDbContext
    {
        public HelpIncContext(DbContextOptions<HelpIncContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Address>();
            modelBuilder.Ignore<Company>();
            modelBuilder.Ignore<Consumer>();
            modelBuilder.Ignore<Geolocalization>();
            modelBuilder.Ignore<Group>();
            modelBuilder.Ignore<GroupRole>();
            modelBuilder.Ignore<Provider>();
            modelBuilder.Ignore<Skill>();
            modelBuilder.Ignore<SkillLevel>();

            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ConsumerConfiguration());
            modelBuilder.ApplyConfiguration(new GeolocalizationConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new SkillLevelConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Consumer> Consumer { get; set; }
        public DbSet<Geolocalization> Geolocalization { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupRole> GroupRole { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillLevel> SkillLevel { get; set; }
    }
}
using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RevisionControl.Authorization.Roles;
using RevisionControl.Authorization.Users;
using RevisionControl.MultiTenancy;

namespace RevisionControl.EntityFrameworkCore
{
    public class RevisionControlDbContext : AbpZeroDbContext<Tenant, Role, User, RevisionControlDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public RevisionControlDbContext(DbContextOptions<RevisionControlDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
    	
            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(10485759); // any integer that is smaller than 10485760
        }
    }
}

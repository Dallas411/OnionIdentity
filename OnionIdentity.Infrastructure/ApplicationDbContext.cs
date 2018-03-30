using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnionIdentity.Core.Entities.Models;

namespace OnionIdentity.Infrastructure
{
    //public class ApplicationDbContext : DbContext
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //public ApplicationDbContext(DbContextOptions options) : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("AppIdentityUsers");
            builder.Entity<ApplicationRole>().ToTable("AppIdentityRole");
            builder.Entity<ApplicationUserRole<int>>(i => {
                i.ToTable("AppIdentityUserRole");
                i.HasKey(x => new { x.RoleId, x.UserId });
            });
            builder.Entity<ApplicationUserLogin<int>>(i => {
                i.ToTable("AppIdentityUserLogin");
                i.HasKey(x => new { x.ProviderKey, x.LoginProvider });
            });
            builder.Entity<ApplicationRoleClaim<int>>(i => {
                i.ToTable("AppIdentityRoleClaims");
                i.HasKey(x => x.Id);
            });
            builder.Entity<ApplicationUserClaim<int>>(i => {
                i.ToTable("AppIdentityUserClaims");
                i.HasKey(x => x.Id);
            });
        }
    }
}

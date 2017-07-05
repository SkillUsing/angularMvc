using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ElecSales.WebTools
{
    public class ApplicationDbContext :
        IdentityDbContext<ApplicationUser, IdentityRole, int, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>
    {
        static ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public ApplicationDbContext() : base("DefaultConnection")
        {
            Configuration.UseDatabaseNullSemantics = false;
            Configuration.LazyLoadingEnabled = true;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            MyBuilder<ApplicationUser, IdentityUserRole, int, IdentityUserClaim, IdentityUserLogin, IdentityRole>(modelBuilder);
        }

        private static void MyBuilder<TUser, TUserRole, TKey, TUserClaim, TUserLogin, TRole>(DbModelBuilder modelBuilder)
            where TUser : ApplicationUser
            where TRole : IdentityRole<TKey, TUserRole>
            where TUserLogin : IdentityUserLogin<TKey>
            where TUserRole : IdentityUserRole<TKey>
            where TUserClaim : IdentityUserClaim<TKey>
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));
            var user = modelBuilder.Entity<TUser>()
                .ToTable("Accounts");
            user.HasMany(u => u.Roles).WithRequired().HasForeignKey(ur => ur.UserId);
            user.HasMany(u => u.Claims).WithRequired().HasForeignKey(uc => uc.UserId);
            user.HasMany(u => u.Logins).WithRequired().HasForeignKey(ul => ul.UserId);
            user.Property(u => u.UserName).IsRequired().HasMaxLength(256)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UserNameIndex")
                {
                    IsUnique = true
                }));

            user.Property(c => c.Email).HasMaxLength(256);
            modelBuilder.Entity<TUserRole>()
                .HasKey(r => new { r.UserId, r.RoleId })
                .ToTable("AccountRoleRelation");

            modelBuilder.Entity<TUserLogin>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId })
                .ToTable("AccountLoginRelation");

            modelBuilder.Entity<TUserClaim>()
                .ToTable("AccountClaims");

            var role = modelBuilder.Entity<TRole>()
                .ToTable("AccountRoles");
            role.Property(r => r.Name).IsRequired().HasMaxLength(256).HasColumnAnnotation("Index",
                new IndexAnnotation(new IndexAttribute("RoleNameIndex")
                {
                    IsUnique = true,
                }));

            role.HasMany(r => r.Users).WithRequired().HasForeignKey(ur => ur.RoleId);
        }
    }
}
using Herbzhub.Data.Models;
using Herbzhub.Data.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Herbzhub.Data
{
    public class DbApplicationContext : DbContext
    {
        public DbApplicationContext(DbContextOptions<DbApplicationContext> options) : base(options){ }


            public DbSet<Counties> Counties { get; set; }
            public DbSet<Country> Countries { get; set; }
            public DbSet<City> cities { get; set; }
            public DbSet<State> States { get; set; }

            public DbSet<User> Users { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<UserRole> UserRoles { get; set; }

            public DbSet<PersonalIdentification> PersonalIdentifications { get; set; }

            public DbSet<ManufacturerDispensary> ManufacturerDispensaries { get; set; }

            public DbSet<SMSVerificationCode> SMSVerificationCodes { get; set; }
          



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ManufacturerDispensary>()
                .HasOne(u => u.PersonalIdentification)
                .WithMany(u => u.ManufacturerDispensary)
                .HasForeignKey(u => u.PersonalIdentificationId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserRole) // User has many UserRoles
                .WithOne(ur => ur.User) // UserRole belongs to one User
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Role>()
                .HasMany(u => u.UserRole)
                .WithOne(s => s.Role)
                .HasForeignKey(s => s.RoleId);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<ManufacturerDispensary>()
                .HasIndex(u => u.StateLicenseNumber)
                .IsUnique();

            modelBuilder.Entity<ManufacturerDispensary>()
                .HasIndex(u=>u.BusinessEmail)
                .IsUnique();

            modelBuilder.Entity<ManufacturerDispensary>()
                .HasIndex(u => u.BusinessEIN)
                .IsUnique();
         


            modelBuilder.ApplyConfiguration(new CountryTableSeeder());
            modelBuilder.ApplyConfiguration(new StateTableSeeder());
            modelBuilder.ApplyConfiguration(new CityTableSeeder());
            modelBuilder.ApplyConfiguration(new RoleTableSeeder());
            modelBuilder.ApplyConfiguration(new CountiesTableSeeder());
            UserSeedData.Seed(modelBuilder);
        }
    
    }
}

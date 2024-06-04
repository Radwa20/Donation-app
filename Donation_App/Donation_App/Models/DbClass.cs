using Microsoft.EntityFrameworkCore;

namespace Donation_App.Models
{
    internal class DbClass : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) =>
            dbContextOptionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ourApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donor>()
                .Property(u => u.Password)
                .HasConversion(
                    v => new Donor().Hash(v),
                    v => v);

            modelBuilder.Entity<Organization>()
               .Property(u => u.OrgPassword)
               .HasConversion(
                   v => new Organization().Hash(v),
                   v => v);

            modelBuilder.Entity<Donation>()
             .Property(u => u.Card_number)
             .HasConversion(
                 v => new Donation().Hash(v),
                 v => v);

            modelBuilder.Entity<Donation>()
           .Property(u => u.CVC)
           .HasConversion(
               v => new Donation().Hash(v),
               v => v);

            modelBuilder.Entity<Donor>()
                .HasMany(p => p.Organizations)
                .WithMany(s => s.Donors)
                .UsingEntity<Donation>(
                j => j.HasOne(p => p.Organization).WithMany(p => p.Donations).HasForeignKey(p => p.OrganizationEmail),
                j => j.HasOne(p => p.Donor).WithMany(p => p.Donations).HasForeignKey(p => p.DonorEmail),
                j => j.HasKey(i => new { i.DonationId })
                );
        }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Donation> Donations { get; set; }

    }
}

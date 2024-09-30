using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCities.Core.Models;
using SmartCities.EF.Configrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Partener> Parteners { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ClientProducts> ClientProducts { get; set; }
        public virtual DbSet<PartenerProducts> PartenerProducts { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<New> News { get; set; }
        public virtual DbSet<ContactRequests> Requests { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<ProjectTeam> ProjectTeams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>()
                .HasOne(e => e.User)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.CreateBy)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasOne(e => e.User)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CreateBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(e => e.ParentProduct)
                .WithMany(e => e.SubProducts)
                .HasForeignKey(e => e.ParentProductId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Team>()
                .HasOne(e => e.User)
                .WithMany(e => e.Teams)
                .HasForeignKey(e => e.CreateBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partener>()
               .HasOne(e => e.User)
               .WithMany(e => e.Parteners)
               .HasForeignKey(e => e.CreateBy)
               .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<New>()
         .HasOne(e => e.User)
         .WithMany(e => e.News)
         .HasForeignKey(e => e.CreateBy)
         .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Client>()
       .HasOne(e => e.User)
       .WithMany(e => e.Clients)
       .HasForeignKey(e => e.CreateBy)
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Client>()
                .Property(e => e.CreateAt)
               .HasDefaultValueSql("GETDATE()");
           

            modelBuilder.Entity<Team>()
                .Property(e => e.CreateAt)
               .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Partener>()
                .Property(e => e.CreateAt)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ContactRequests>()
               .Property(e => e.CreateBy)
              .HasDefaultValue("externel ContactRequests");

            modelBuilder.Entity<ContactRequests>()
           .Property(e => e.UpdateBy)
          .HasDefaultValue("externel ContactRequests");

            modelBuilder.Entity<Subscriber>()
              .Property(e => e.CreateBy)
             .HasDefaultValue("externel Subscriber");

            modelBuilder.Entity<Subscriber>()
           .Property(e => e.UpdateBy)
          .HasDefaultValue("externel Subscriber");




            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "Admin".ToUpper() });
            var password = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Email = "aufci266@gmail.com",
                FirstName = "Gamal",
                LastName = "Kassem",
                //IsDeleted = false,
                PasswordHash = password.HashPassword(null, "Homfci@23"),
                NormalizedEmail = "aufci266@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "aufci266@gmail.com".ToUpper(),
                PhoneNumber = "01026691741".ToUpper(),
                PhoneNumberConfirmed = true,
                UserName = "aufci266@gmail.com",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            });



            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new PartenerConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
        }
    }
    }

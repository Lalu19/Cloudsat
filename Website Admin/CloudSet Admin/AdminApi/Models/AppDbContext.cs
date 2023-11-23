 using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using AdminApi;
using AdminApi.Models;
using AdminApi.Models.App;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models
{
    public class AppDbContext:DbContext
    {     
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Websitepages> Websitepages { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Homepage> Homepages { get; set; }
        public virtual DbSet<Pricing> Pricings { get; set; }
        public virtual DbSet<Pricingproduct> Pricingproducts { get; set; }
        
        public virtual DbSet<PlanningMaster> PlanningMasters { get; set; }
        public virtual DbSet<ApplicationMaster> ApplicationMasters { get; set; }
        public virtual DbSet<planningAndApplication> PlanningAndApplications { get; set; }
        public virtual DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }
        public virtual DbSet<termsandconditions> Termsandconditions { get; set; }
        public virtual DbSet<SubscriptionAppliction> SubscriptionApplictions { get; set; }
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<JobOpening> JobOpening { get; set; }
        public virtual DbSet<Careers> Careers { get; set; }
        public virtual DbSet<DownloadApp> DownloadApps { get; set; }
        public virtual DbSet<BetterProduct> BetterProducts { get; set; }
        public virtual DbSet<MargERP> MargERPs { get; set; }
        public virtual DbSet<AllViewBanner> AllViewBanners { get; set; }
        public virtual DbSet<BestFeaturedProducts> BestFeaturedProducts { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
                                //modelBuilder.SeedOracle();//use this only for Oracle
            #region 

            //Hospital


            modelBuilder.Entity<Category>()
            .HasMany(e => e.Children)

            .WithOne() // EF Core
            .HasForeignKey(e => e.Parent);

            modelBuilder.Entity<Category>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Category>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            //Website pages start
            modelBuilder.Entity<Websitepages>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Websitepages>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Website pages end

            //Image start 
            modelBuilder.Entity<Image>()
           .Property(s => s.CreatedOn)
           .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Image>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();
            //Image end

            modelBuilder.Entity<Banner>()
         .Property(s => s.CreatedOn)
         .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Banner>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<Pricing>()
         .Property(s => s.CreatedOn)
         .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Pricing>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<Pricingproduct>()
          .Property(s => s.CreatedOn)
          .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Pricingproduct>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<ApplicationMaster>()
         .Property(s => s.CreatedOn)
         .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ApplicationMaster>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<PlanningMaster>()
         .Property(s => s.CreatedOn)
         .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<PlanningMaster>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<planningAndApplication>()
         .Property(s => s.CreatedOn)
         .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<planningAndApplication>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<PrivacyPolicy>()
        .Property(s => s.CreatedOn)
        .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<PrivacyPolicy>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<termsandconditions>()
        .Property(s => s.CreatedOn)
        .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<termsandconditions>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<SubscriptionAppliction>()
       .Property(s => s.CreatedOn)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<SubscriptionAppliction>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<AboutUs>()
      .Property(s => s.CreatedOn)
      .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AboutUs>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<JobOpening>()
    .Property(s => s.CreatedOn)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<JobOpening>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Careers>()
   .Property(s => s.CreatedOn)
   .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Careers>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<DownloadApp>()
  .Property(s => s.CreatedOn)
  .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<DownloadApp>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<BetterProduct>()
 .Property(s => s.CreatedOn)
 .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<BetterProduct>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<MargERP>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<MargERP>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<AllViewBanner>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AllViewBanner>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<BestFeaturedProducts>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<BestFeaturedProducts>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            #endregion
        }

    }
}

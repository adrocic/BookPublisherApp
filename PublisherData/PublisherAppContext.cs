﻿using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PublisherDomain;

namespace PublisherData
{
    public class PublisherAppContext : DbContext
    {
        public PublisherAppContext()
        {
            SavingChanges += SavingChangesHandler;
        }

        private void SavingChangesHandler(object? sender, SavingChangesEventArgs e)
        {
            UpdateAuditData();
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cover> Covers { get; set; }

        private void UpdateAuditData()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity is Author))
            {
                entry.Property("LastUpdated").CurrentValue = DateTime.Now;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BookPublisherDB"
            ).LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information)
            .EnableSensitiveDataLogging()
            .AddInterceptors(new MyCustomDbCommandInterceptor());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FakeData.Init(100);
            //Add a shadow property to one type
            modelBuilder.Entity<Author>().Property<DateTime>("LastUpdated");

            modelBuilder.Entity<Author>().HasData(FakeData.Authors);

            modelBuilder.Entity<Book>().HasData(FakeData.Books);

            modelBuilder.Entity<Cover>().HasData(FakeData.Covers);
            
            modelBuilder.Entity<Artist>().HasData(FakeData.Artists);

             //Add a shadow property to all entity types
            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    if (!entityType.IsOwned())
            //        modelBuilder.Entity(entityType.Name).Property<DateTime>("LastUpdated");
            //}
        }

        //public override int SaveChanges()
        //{
        //    var entries=ChangeTracker.Entries().ToList();
        //    var authors=ChangeTracker.Entries().Where(e=>e.Entity is Author).ToList();

        //    return 0;
        //}

    }

}


//private void UpdateAuditDataHandler(object? sender, SavingChangesEventArgs e)
//{
//    UpdateAuditData();
//}



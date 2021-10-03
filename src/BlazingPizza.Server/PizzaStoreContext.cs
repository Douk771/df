﻿using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazingPizza.Server
{
    public class PizzaStoreContext : ApiAuthorizationDbContext<PizzaStoreUser>
    {
        public PizzaStoreContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Nomination> Nominations { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           // Inline the Lat-Long pairs in Order rather than having a FK to another table
            modelBuilder.Entity<Order>().OwnsOne(o => o.DeliveryLocation);
        }
    }
}

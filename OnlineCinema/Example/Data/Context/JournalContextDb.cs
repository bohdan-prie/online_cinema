using System.Reflection;
using OnlineCinema.Example.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineCinema.Example.Data.Context
{
    public sealed class JournalContextDb : DbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<SubscriptionEntity> Subscriptions { get; set; }
        public DbSet<UserPaymentInfoEntity> UserPaymentInfo { get; set; }

        public JournalContextDb(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(JournalContextDb))!);
        }
    }
}
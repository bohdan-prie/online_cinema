using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCinema.Example.Data.Entities;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class SubscriptionsConfiguration : IEntityTypeConfiguration<SubscriptionEntity>
    {
        public void Configure(EntityTypeBuilder<SubscriptionEntity> builder)
        {
            builder
                .ToTable("Subscriptions");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Price)
                .IsRequired();

            builder
                .Property(p => p.DurationInMonth)
                .IsRequired();
        }
    }
}



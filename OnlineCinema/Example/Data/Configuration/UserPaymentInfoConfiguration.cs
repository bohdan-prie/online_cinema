using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCinema.Example.Data.Entities;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class UserPaymentInfoConfiguration : IEntityTypeConfiguration<UserPaymentInfoEntity>
    {
        public void Configure(EntityTypeBuilder<UserPaymentInfoEntity> builder)
        {
            builder
                .ToTable("UserPaymentInfo");

            builder
                .HasKey(p => p.UserId);

            builder
                .HasOne(info => info.Subscription)
                .WithMany(subscription => subscription.UserPaymentInfo)
                .HasForeignKey(info => info.SubscriptionId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasOne(info => info.User)
                .WithOne(user => user.UserPaymentInfo)
                .HasForeignKey<UserPaymentInfoEntity>(info => info.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}




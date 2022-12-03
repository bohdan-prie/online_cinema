using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCinema.Example.Data.Entities;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class UsersConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder
                .ToTable("Users");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Username)
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.Password)
                .HasMaxLength(128)
                .IsRequired();
        }
    }
}


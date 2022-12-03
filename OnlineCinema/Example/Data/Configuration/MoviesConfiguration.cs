using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineCinema.Example.Data.Entities;

namespace LecturesProjectExample.Example.Data.Configurations
{
    public sealed class MoviesConfiguration : IEntityTypeConfiguration<MovieEntity>
    {
        public void Configure(EntityTypeBuilder<MovieEntity> builder)
        {
            builder
                .ToTable("Movies");

            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.Price)
                .IsRequired();
        }
    }
}

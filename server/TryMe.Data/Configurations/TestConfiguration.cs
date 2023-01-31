using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TryMe.Domain.Entities;

namespace TryMe.Data.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("Tests")
                   .HasKey(t => t.Id);

            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(t => t.Description)
                   .HasMaxLength(80);

            builder.HasOne(t => t.User)
                   .WithMany(u => u.Tests);

            builder.HasMany(t => t.Questions)
                   .WithOne(q => q.Test);
        }
    }
}

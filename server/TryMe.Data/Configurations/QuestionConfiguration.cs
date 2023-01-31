using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TryMe.Domain.Entities;

namespace TryMe.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions")
                   .HasKey(q => q.Id);

            builder.Property(q => q.Answer)
                   .IsRequired()
                   .HasMaxLength(220);

            builder.Property(q => q.IsCorrect)
                   .HasColumnType("boolean");

            builder.HasOne(q => q.Test)
                   .WithMany(t => t.Questions);
        }
    }
}

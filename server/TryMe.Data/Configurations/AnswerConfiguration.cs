using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TryMe.Domain.Entities;

namespace TryMe.Data.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answers")
                   .HasIndex(a => a.Id);

            builder.Property(a => a.Body)
                   .IsRequired()
                   .HasMaxLength(400);

            builder.Property(a => a.IsCorrect)
                   .IsRequired()
                   .HasColumnType("BOOLEAN");

            builder.HasOne(a => a.Question)
                   .WithMany(q => q.Answers)
                   .HasForeignKey(a => a.QuestionId);
        }
    }
}

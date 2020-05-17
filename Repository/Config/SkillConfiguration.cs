using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(ski => ski.Id);

            builder.Property(ski => ski.Description).IsRequired(true).HasMaxLength(300).HasColumnType("VARCHAR(300)");
            builder.Property(ski => ski.Picture).IsRequired(false).HasMaxLength(160).HasColumnType("VARCHAR(160)");
        }
    }
}
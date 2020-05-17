using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class SkillLevelConfiguration : IEntityTypeConfiguration<SkillLevel>
    {
        public void Configure(EntityTypeBuilder<SkillLevel> builder)
        {
            builder.HasKey(skl => skl.Id);
            builder.HasOne(skl => skl.SkillLevelSkill).WithMany().HasForeignKey(skl => skl.IdSkill);

            builder.Property(skl => skl.Level).IsRequired(true).HasMaxLength(3).HasColumnType("INTEGER(3)");
        }
    }
}
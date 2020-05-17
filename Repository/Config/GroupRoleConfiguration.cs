using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class GroupRoleConfiguration : IEntityTypeConfiguration<GroupRole>
    {
        public void Configure(EntityTypeBuilder<GroupRole> builder)
        {
            builder.HasKey(gpr => gpr.Id);
            builder.HasOne(gpr => gpr.ProviderOfficer).WithMany().HasForeignKey(act => act.IdProvider);

            builder.Property(gpr => gpr.Role).IsRequired(true).HasMaxLength(1).HasColumnType("INTEGER(1)");
        }
    }
}
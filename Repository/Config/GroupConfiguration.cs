using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(grp => grp.Id);
            builder.HasMany(grp => grp.GroupProvider).WithOne(pro => pro.ProviderGroup).HasForeignKey(pro => pro.Id);
            builder.HasMany(grp => grp.GroupGroupRole).WithOne(gpr => gpr.GroupRoleGroup).HasForeignKey(gpr => gpr.Id);

            builder.Property(grp => grp.Name).IsRequired(true).HasMaxLength(40).HasColumnType("VARCHAR(40)");
            builder.Property(grp => grp.Description).IsRequired(false).HasMaxLength(200).HasColumnType("VARCHAR(200)");
            builder.Property(grp => grp.Picture).IsRequired(false).HasMaxLength(160).HasColumnType("VARCHAR(160)");
        }
    }
}
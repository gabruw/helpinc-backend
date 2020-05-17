using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(act => act.Id);
            builder.HasOne(act => act.ActorLoginUser).WithMany().HasForeignKey(act => act.IdLogin);
            builder.HasOne(act => act.ActorAddress).WithMany().HasForeignKey(act => act.IdAddress);

            builder.Property(act => act.Name).IsRequired(true).HasMaxLength(240).HasColumnType("VARCHAR(240)");
            builder.Property(act => act.Phone).IsRequired(true).HasMaxLength(10).HasColumnType("INTEGER(10)");
            builder.Property(act => act.Picture).IsRequired(false).HasMaxLength(160).HasColumnType("VARCHAR(160)");

            builder.Property(use => use.CellPhone).IsRequired(true).HasMaxLength(11).HasColumnType("BIGINT(11)");
            builder.Property(use => use.Rg).IsRequired(true).HasMaxLength(11).HasColumnType("VARCHAR(11)");
            builder.Property(use => use.Cpf).IsRequired(true).HasMaxLength(11).HasColumnType("BIGINT(11)");

            builder.HasOne(pro => pro.Group).WithMany().HasForeignKey(pro => pro.IdGroup);
            builder.HasMany(pro => pro.Skills).WithOne(ski => ski.ProviderSkill).HasForeignKey(ski => ski.Id);
        }
    }
}
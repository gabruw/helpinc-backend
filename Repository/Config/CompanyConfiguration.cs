using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(act => act.Id);
            builder.HasOne(act => act.ActorLoginUser).WithMany().HasForeignKey(act => act.IdLogin);
            builder.HasOne(act => act.ActorAddress).WithMany().HasForeignKey(act => act.IdAddress);

            builder.Property(act => act.Name).IsRequired(true).HasMaxLength(240).HasColumnType("VARCHAR(240)");
            builder.Property(act => act.Phone).IsRequired(true).HasMaxLength(10).HasColumnType("INTEGER(10)");
            builder.Property(act => act.Picture).IsRequired(false).HasMaxLength(160).HasColumnType("VARCHAR(160)");
            builder.Property(com => com.TradingName).IsRequired(true).HasMaxLength(80).HasColumnType("VARCHAR(80)");
            builder.Property(com => com.Cnpj).IsRequired(true).HasMaxLength(14).HasColumnType("BIGINT(14)");
        }
    }
}
using Data.EF.Extensions;
using Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.Configurations
{
    internal class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}
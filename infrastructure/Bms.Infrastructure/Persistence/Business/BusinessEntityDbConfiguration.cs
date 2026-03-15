using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bms.Infrastructure.Persistence.Business;

public class BusinessEntityDbConfiguration : IEntityTypeConfiguration<Domain.Entities.Business>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Business> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}
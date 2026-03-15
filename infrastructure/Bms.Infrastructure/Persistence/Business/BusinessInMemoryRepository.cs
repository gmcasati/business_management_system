using Bms.Domain.Repositories;

namespace Bms.Infrastructure.Persistence.Business;

public class BusinessInMemoryRepository(BusinessesDbContext dbContext) : IBusinessRepository
{
    private readonly BusinessesDbContext _dbContext = dbContext;

    public async Task<Domain.Entities.Business> AddBusinessAsync(Domain.Entities.Business business, CancellationToken cancellationToken)
    {
        await _dbContext.AddAsync(business, cancellationToken);
        await  _dbContext.SaveChangesAsync(cancellationToken);
        return business;
    }
}
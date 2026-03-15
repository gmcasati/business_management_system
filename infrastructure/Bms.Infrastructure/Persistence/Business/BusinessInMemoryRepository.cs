using Bms.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bms.Infrastructure.Persistence.Business;

public class BusinessInMemoryRepository(BusinessesDbContext dbContext) : IBusinessRepository
{
    private readonly BusinessesDbContext _dbContext = dbContext;

    public async Task<Domain.Entities.Business> AddBusinessAsync(Domain.Entities.Business business, CancellationToken cancellationToken)
    {
        await _dbContext.Businesses.AddAsync(business, cancellationToken);
        await  _dbContext.SaveChangesAsync(cancellationToken);
        return business;
    }

    public async Task<List<Domain.Entities.Business>> GetBusinessAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Businesses.ToListAsync(cancellationToken: cancellationToken);
    }
}
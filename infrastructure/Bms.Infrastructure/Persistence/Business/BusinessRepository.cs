using Bms.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Bms.Infrastructure.Persistence.Business;

public class BusinessRepository(BusinessesDbContext dbContext) : IBusinessRepository
{
    private readonly BusinessesDbContext _dbContext = dbContext;

    public async Task<Domain.Entities.Business> AddBusinessAsync(Domain.Entities.Business business, CancellationToken cancellationToken)
    {
        await _dbContext.Businesses.AddAsync(business, cancellationToken);
        await  _dbContext.SaveChangesAsync(cancellationToken);
        return business;
    }

    public async Task<List<Domain.Entities.Business>> GetBusinessesAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Businesses.ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<Domain.Entities.Business?> GetBusinessAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.Businesses.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<Domain.Entities.Business> UpdateBusinessAsync(Domain.Entities.Business business, CancellationToken cancellationToken)
    {
        _dbContext.Businesses.Update(business);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return business;
    }

    public async Task<Domain.Entities.Business> DeleteBusinessAsync(Domain.Entities.Business business, CancellationToken cancellationToken)
    {
        _dbContext.Businesses.Remove(business);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return business;
    }
}
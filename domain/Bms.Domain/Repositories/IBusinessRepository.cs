using Bms.Domain.Entities;

namespace Bms.Domain.Repositories;

public interface IBusinessRepository
{
    public Task<Business> AddBusinessAsync(Business business, CancellationToken cancellationToken);
    public Task<List<Business>> GetBusinessAsync(CancellationToken cancellationToken);
}
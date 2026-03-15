using Bms.Domain.Entities;

namespace Bms.Domain.Repositories;

public interface IBusinessRepository
{
    public Task<Business> AddBusinessAsync(Business business, CancellationToken cancellationToken);
    public Task<List<Business>> GetBusinessesAsync(CancellationToken cancellationToken);
    public Task<Business?> GetBusinessAsync(Guid id, CancellationToken cancellationToken);
    public Task<Business> UpdateBusinessAsync(Business business, CancellationToken cancellationToken);
}
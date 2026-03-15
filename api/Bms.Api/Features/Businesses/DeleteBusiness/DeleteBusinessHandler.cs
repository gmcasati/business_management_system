using Bms.Domain;
using Bms.Domain.Entities;
using Bms.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bms.Api.Features.Businesses.DeleteBusiness;

public class DeleteBusinessHandler(IBusinessRepository businessRepository)
{
    public async Task<DeleteBusinessResponse?> HandleAsync(Guid businessId, CancellationToken ct)
    {
        var business = await businessRepository.GetBusinessAsync(businessId, ct);
        if (business == null) return null;
        await businessRepository.DeleteBusinessAsync(business, ct);
        return new DeleteBusinessResponse()
        {
            Id = business.Id
        };
    }
}
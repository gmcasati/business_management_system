using Bms.Domain;
using Bms.Domain.Entities;
using Bms.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bms.Api.Features.Businesses.BusinessDetail;

public class BusinessDetailHandler(IBusinessRepository businessRepository)
{
    public async Task<BusinessDetailResponse?> HandleAsync(Guid businessId, CancellationToken ct)
    {
        var business = await businessRepository.GetBusinessAsync(businessId, ct);

        return business is null ? null : new BusinessDetailResponse()
        {
            Id = business.Id,
            Name = business.Name,
            EntrepreneurName = business.EntrepreneurName,
            BusinessSector = (int)business.Status,
            Status = (int)business.Status,
            Municipality =  business.Municipality,
            EmailOrContact =  business.EmailOrContact
        };
    }
}
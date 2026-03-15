using Bms.Api.Dtos.Businesses;
using Bms.Domain;
using Bms.Domain.Entities;
using Bms.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bms.Api.Features.Businesses.ListBusinesses;

public class ListBusinessesHandler(IBusinessRepository businessRepository)
{
    public async Task<ListBusinessesResponse> HandleAsync(ListBusinessesRequest request, CancellationToken ct)
    {
        var businesses = await businessRepository.GetBusinessesAsync(ct);

        return new ListBusinessesResponse()
        {
            Total = businesses?.Count() ?? 0, Businesses = businesses?.Select(x => new BusinessReadDto()
            {
                Id = x.Id,
                Name = x.Name,
                EntrepreneurName = x.EntrepreneurName,
                BusinessSector = (int)x.Status,
                Status = (int)x.Status,
                Municipality =  x.Municipality,
                EmailOrContact =  x.EmailOrContact
            }).ToList()?? new List<BusinessReadDto>()
        };
    }
}
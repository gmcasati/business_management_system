using Bms.Domain;
using Bms.Domain.Entities;
using Bms.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bms.Api.Features.Businesses.CreateBusiness;

public class CreateBusinessHandler(IBusinessRepository businessRepository)
{
    private readonly IBusinessRepository _businessRepository = businessRepository;

    public async Task<CreateBusinessResponse> HandleAsync(CreateBusinessRequest request, CancellationToken ct)
    {
        var newBusiness = new Domain.Entities.Business
        {
            Name = request.Name,
            EntrepreneurName = request.EntrepreneurName,
            Municipality =  request.Municipality,
            BusinessSector = (BusinessSectorEnum)request.BusinessSector,
            Status = (BusinessStatusEnum)request.Status,
            EmailOrContact = request.EmailOrContact,
        };
        var business = await _businessRepository.AddBusinessAsync(newBusiness, ct);
        
        return new CreateBusinessResponse() { Id = business.Id };
    }
}
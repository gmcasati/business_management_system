using Bms.Domain;
using Bms.Domain.Entities;
using Bms.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bms.Api.Features.Businesses.UpdateBusiness;

public class UpdateBusinessHandler(IBusinessRepository businessRepository)
{
    private readonly IBusinessRepository _businessRepository = businessRepository;

    public async Task<UpdateBusinessResponse?> HandleAsync(Guid businessId, UpdateBusinessRequest request, CancellationToken ct)
    {
        var businessToUpdate = await _businessRepository.GetBusinessAsync(businessId, ct);
        if (businessToUpdate is null) return  null;
        
        businessToUpdate.Name = request.Name;
        businessToUpdate.EmailOrContact = request.EmailOrContact;
        businessToUpdate.BusinessSector = (BusinessSectorEnum)request.BusinessSector;
        businessToUpdate.Municipality = request.Municipality;
        businessToUpdate.EntrepreneurName = request.EntrepreneurName;
        businessToUpdate.Status = (BusinessStatusEnum)request.Status;
        
        var business = await _businessRepository.UpdateBusinessAsync(businessToUpdate, ct);
        return new UpdateBusinessResponse() { Id = business.Id };
    }
}
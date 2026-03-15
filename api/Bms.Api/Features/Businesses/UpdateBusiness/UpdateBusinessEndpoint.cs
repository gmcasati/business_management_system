using Bms.Api.Features.Businesses.BusinessDetail;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Bms.Api.Features.Businesses.UpdateBusiness;

public static class UpdateBusinessEndpoint
{
    public static RouteGroupBuilder MapUpdateBusinessEndpoint(this RouteGroupBuilder group)
    {
        group.MapPut("/{businessId}", async Task<Results<Ok<Guid>, NotFound>>(
            Guid businessId,
            UpdateBusinessRequest request,
            UpdateBusinessHandler handler,
            CancellationToken ct) =>
        {
            var result = await handler.HandleAsync(businessId, request, ct);
            if (result is null)
            {
                return TypedResults.NotFound();
            }
            
            return TypedResults.Ok(result.Id);
        });

        return group;
    }
}
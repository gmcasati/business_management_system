using Microsoft.AspNetCore.Http.HttpResults;

namespace Bms.Api.Features.Businesses.BusinessDetail;

public static class BusinessDetailEndpoint
{
    public static RouteGroupBuilder MapBusinessDetailEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/{businessId:guid}", async Task<Results<Ok<BusinessDetailResponse>, NotFound>>(Guid businessId, BusinessDetailHandler handler,
            CancellationToken ct) =>
        {
            var result = await handler.HandleAsync(businessId, ct);
            if (result is null) return TypedResults.NotFound();
            return  TypedResults.Ok(result);
        })
        .WithName("BusinessDetail")
        .WithSummary("Show business details")
        .WithDescription("Advanced details for a single business");

        return group;
    }
}
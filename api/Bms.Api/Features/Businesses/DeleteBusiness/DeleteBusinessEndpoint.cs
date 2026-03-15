using Microsoft.AspNetCore.Http.HttpResults;

namespace Bms.Api.Features.Businesses.DeleteBusiness;

public static class DeleteBusinessEndpoint
{
    public static RouteGroupBuilder MapDeleteBusinessEndpoint(this RouteGroupBuilder group)
    {
        group.MapDelete("/{businessId:guid}", async Task<Results<NoContent, NotFound>>(Guid businessId, DeleteBusinessHandler handler,
            CancellationToken ct) =>
        {
            var result = await handler.HandleAsync(businessId, ct);
            if (result is null) return TypedResults.NotFound();
            return  TypedResults.NoContent();
        })
        .WithName("DeleteBusiness")
        .WithSummary("Deleting a business")
        .WithDescription("Deletes a business by its id");

        return group;
    }
}
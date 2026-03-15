namespace Bms.Api.Features.Businesses.ListBusinesses;

public static class ListBusinessesEndpoint
{
    public static RouteGroupBuilder MapListBusinessesEndpoint(this RouteGroupBuilder group)
    {
        group.MapGet("/", async (
            [AsParameters] ListBusinessesRequest request,
            ListBusinessesHandler handler,
            CancellationToken ct) =>
        {
            var result = await handler.HandleAsync(request, ct);
            return TypedResults.Ok(result);
        })
        .WithName("ListBusinesses")
        .WithSummary("List business")
        .WithDescription("List business");

        return group;
    }
}
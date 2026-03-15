namespace Bms.Api.Features.Businesses.CreateBusiness;

public static class CreateBusinessEndpoint
{
    public static RouteGroupBuilder MapCreateBusinessEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/", async (
            CreateBusinessRequest request,
            CreateBusinessHandler handler,
            CancellationToken ct) =>
        {
            var result = await handler.HandleAsync(request, ct);
            return TypedResults.Created($"/api/businesses/{result.Id}", result);
        })
        .WithName("CreateBusiness")
        .WithSummary("Create a new business")
        .WithDescription("Registers a business and returns the created resource with its generated id.");

        return group;
    }
}
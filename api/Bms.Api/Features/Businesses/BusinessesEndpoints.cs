using Bms.Api.Features.Businesses.CreateBusiness;

namespace Bms.Api.Features.Businesses;

public static class BusinessesEndpoints
{
    public static IEndpointRouteBuilder MapBusinessesEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/businesses")
            .WithTags("Businesses");

        group.MapCreateBusinessEndpoint();
        
        return app;
    }
}
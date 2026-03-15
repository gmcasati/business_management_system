using Bms.Api.Features.Businesses.CreateBusiness;
using Bms.Api.Features.Businesses.ListBusinesses;

namespace Bms.Api.Features.Businesses;

public static class BusinessesEndpoints
{
    public static IEndpointRouteBuilder MapBusinessesEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/businesses")
            .WithTags("Businesses");

        group.MapCreateBusinessEndpoint();
        group.MapListBusinessesEndpoint();
        return app;
    }
}
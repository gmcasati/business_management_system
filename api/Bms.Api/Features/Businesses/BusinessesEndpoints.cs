using Bms.Api.Features.Businesses.BusinessDetail;
using Bms.Api.Features.Businesses.CreateBusiness;
using Bms.Api.Features.Businesses.DeleteBusiness;
using Bms.Api.Features.Businesses.ListBusinesses;
using Bms.Api.Features.Businesses.UpdateBusiness;

namespace Bms.Api.Features.Businesses;

public static class BusinessesEndpoints
{
    public static IEndpointRouteBuilder MapBusinessesEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/businesses")
            .WithTags("Businesses");

        group.MapCreateBusinessEndpoint();
        group.MapListBusinessesEndpoint();
        group.MapBusinessDetailEndpoint();
        group.MapUpdateBusinessEndpoint();
        group.MapDeleteBusinessEndpoint();
        return app;
    }
}
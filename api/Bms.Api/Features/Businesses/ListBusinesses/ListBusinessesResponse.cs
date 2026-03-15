using Bms.Api.Dtos.Businesses;

namespace Bms.Api.Features.Businesses.ListBusinesses;

public class ListBusinessesResponse
{
    public int Total { get; set; }
    public List<BusinessReadDto> Businesses { get; set; } = new List<BusinessReadDto>();
}


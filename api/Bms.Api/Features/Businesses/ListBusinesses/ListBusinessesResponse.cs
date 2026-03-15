using Bms.Api.Features.Businesses.Dto;

namespace Bms.Api.Features.Businesses.ListBusinesses;

public class ListBusinessesResponse
{
    public int Total { get; set; }
    public List<BusinessDto> Businesses { get; set; } = new List<BusinessDto>();
}


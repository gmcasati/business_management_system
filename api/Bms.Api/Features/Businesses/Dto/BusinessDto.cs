namespace Bms.Api.Features.Businesses.Dto;

public class BusinessDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string EntrepreneurName { get; set; }
    public string Municipality { get; set; }
    public int BusinessSector { get; set; }
    public string EmailOrContact { get; set; }
    public int Status { get; set; }
}
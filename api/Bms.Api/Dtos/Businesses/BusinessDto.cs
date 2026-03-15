namespace Bms.Api.Dtos.Businesses;

public class BusinessReadDto : BusinessDto
{
    public Guid Id { get; set; }
}

public class BusinessDto
{
    public string Name { get; set; }
    public string EntrepreneurName { get; set; }
    public string Municipality { get; set; }
    public int BusinessSector { get; set; }
    public string EmailOrContact { get; set; }
    public int Status { get; set; }
}
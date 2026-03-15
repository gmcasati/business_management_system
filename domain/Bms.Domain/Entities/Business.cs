namespace Bms.Domain.Entities;

public class Business
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string EntrepreneurName { get; set; }
    public string Municipality { get; set; }
    public BusinessSectorEnum BusinessSector { get; set; }
    public string EmailOrContact { get; set; }
    public BusinessStatusEnum Status { get; set; }
}
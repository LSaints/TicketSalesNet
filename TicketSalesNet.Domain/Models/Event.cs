namespace TicketSalesNet.Domain.Models;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string ProfileImage { get; set; } = String.Empty;
    public int Amount { get; set; }
    public DateTime CreatedAt { get; set; }
    public double TicketPrice { get; set; }
    public int CompanyId { get; set; }
    public User Company { get; set; }
}
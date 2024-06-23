namespace TicketSalesNet.Domain.Models;

public class User 
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string ProfileImage { get; set; } = String.Empty;
    public string Roles { get; set; } = String.Empty;
    public int IdTicket { get; set; }
    public ICollection<Ticket>? Tickets { get; set; }
    public int IdEvent { get; set; }
    public ICollection<Event>? Events { get; set; }
}
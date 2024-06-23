namespace TicketSalesNet.Domain.Models;

public class Ticket
{
    public int Id { get; set; }
    public int IdEvent { get; set; }
    public Event Event { get; set; }
    public int IdUser { get; set; }
    public User User { get; set; }
    public DateTime PurchaseDate { get; set; }
}
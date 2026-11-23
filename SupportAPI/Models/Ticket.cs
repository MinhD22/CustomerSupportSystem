
namespace SupportAPI.Models;

public class Ticket
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Content { get; set; } = string.Empty;

    public string Priority { get; set; } = "Medium";

    public string Status { get; set; } = "New";

    public string? AssignedTo { get; set; }
    
    public string? AssignedGroup { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

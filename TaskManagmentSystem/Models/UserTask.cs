using System.ComponentModel.DataAnnotations;

namespace TaskManagmentSystem.Models;

public class UserTask
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    [Required]
    public DateTime DueDate { get; set; }
    [Required]
    public string Priority { get; set; } = null!;
}

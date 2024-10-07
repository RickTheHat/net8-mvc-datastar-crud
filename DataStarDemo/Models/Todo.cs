using System.ComponentModel.DataAnnotations;

namespace DataStarDemo.Models;

public class Todo
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? Title { get; set; }
    
    [StringLength(500)]
    public string? Description { get; set; }
    
    public bool IsCompleted { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime? DueDate { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? CompletedAt { get; set; }
}
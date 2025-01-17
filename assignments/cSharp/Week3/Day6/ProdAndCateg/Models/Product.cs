#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ProdAndCateg.Models;

public class Product {
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public double Price { get; set; }
    
    public List<Association> CatAssociation { get; set; } = new List<Association>();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
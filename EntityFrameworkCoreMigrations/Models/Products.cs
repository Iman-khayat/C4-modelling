using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }

    [StringLength(255)]
    public string Description { get; set; }
 
}
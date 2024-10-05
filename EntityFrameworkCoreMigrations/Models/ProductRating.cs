public class ProductRating
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int Rating { get; set; }

    // Add other properties as needed, such as:
    // public string Review { get; set; }
    // public DateTime CreatedAt { get; set; } = DateTime.Now;
}
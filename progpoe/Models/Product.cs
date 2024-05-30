namespace progpoe.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required string ProductCategory { get; set; }
        public required DateOnly ProductionDate { get; set; }
    }
}

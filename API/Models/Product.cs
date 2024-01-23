namespace API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? PurchPrice { get; set; }
        public double SellingPrice { get; set; }
        public string? PicturUrl { get; set; }
        public int? Sale{ get; set; }
        public string? Brand { get; set; }
        public int QuantityInStock { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}

namespace API.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? Description { get; set; }
        public int? ParentCategoryID { get; set; }

        public required Category ParentCategory { get; set; }


        public List<Category>? SubCategories { get; set; }
        public List<Product>? Products { get; set; }
    }
}

namespace MVCapp1.Models
{
    public class ProductSamples
    {
        readonly List<Product> products;
        public ProductSamples()
        {
            products =
            [
                new Product { ID = 1, Name = "Mercedes 1", Price = 100, Description = "CLE Coupe", Image = "1.jpg" },
                new Product { ID = 2, Name = "Mercedes 2", Price = 200, Description = "AMG GT 2025", Image = "2.jpg" },
                new Product { ID = 3, Name = "Mercedes 3", Price = 300, Description = "GLE Class 2025", Image = "3.jpg" },
            ];
        }
        public List<Product> GetAll() => products ?? [];
 
        public Product GetByID(int id) => products?.FirstOrDefault(p => p.ID == id) ?? throw new KeyNotFoundException($"Product with ID {id} not found.");

    }
}

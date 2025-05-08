namespace Catalog.Domain.Entities
{
    public class Product
    {
        public string Id { get; private set; } = null!;
        public string Name { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public decimal Price { get; private set; }
        public string Category { get; private set; } = null!;

        public Product(string name, string description, decimal price, string category)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name is required.");
            if (price < 0) throw new ArgumentException("Price must be non-negative.");

            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }

        protected Product() { }
    }
}

namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Product
    {
        public Product(string title, string description, string image, decimal price, decimal quantity, string itemCatalog)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            Quantity = quantity;
            ItemCatalog = itemCatalog;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public decimal Quantity { get; private set; }
        public string ItemCatalog { get; private set; }
    }
}
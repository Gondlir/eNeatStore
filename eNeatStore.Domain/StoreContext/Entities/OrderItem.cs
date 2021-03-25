namespace eNeatStore.Domain.StoreContext.Entities
{
    public class OrderItem
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
            if (product.Quantity < quantity)
            {
                //Notificar que o produto está fora de estoque
            }
        }

        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public decimal Quantity { get; private set; }
    }
}
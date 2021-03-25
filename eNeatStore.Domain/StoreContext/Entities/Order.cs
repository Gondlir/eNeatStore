using System;
using System.Collections.Generic;
using System.Linq;
using eNeatStore.Domain.StoreContext.Enums;

namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Order
    {
        private readonly IList<OrderItem> _orderItem;
        private readonly IList<Delivery> _delivery;
        public Order(Customer customer)
        {
            Customer = customer;
            Status = EOrderStatus.Created;
            CreatedDate = DateTime.Now;
            _orderItem = new List<OrderItem>();
        }
        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _orderItem.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _delivery.ToArray();

        public void AddItem(Product product, decimal quantity)
        {
            var orderItem = new OrderItem(product, quantity);
            _orderItem.Add(orderItem);
        }
        public void RemoveItem(Product product, decimal quantity)
        {
            var orderItem = new OrderItem(product, quantity);
            _orderItem.Remove(orderItem);
        }

        public void Created()
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            if (_orderItem.Count == 0)
            {
                //Notificação(este pedido não possui items )
            }
        }
        public void Pay()
        {
            //payment context
            Status = EOrderStatus.Payd;
        }
        public void Ship()
        {
            var deliveries = new List<Delivery>(); //cria nova lista de entrega
            deliveries.ForEach(x => x.Sent()); //envia a entrega
            deliveries.ForEach(x => _delivery.Add(x)); //adiciona entrega no pedido
        }
        public void CancelOrder()
        {
            Status = EOrderStatus.OrderCanceled; //status muda para ordem cancelada
            var deliveries = new List<Delivery>(); //é criada a entrega
            deliveries.ForEach(x => x.Canceled()); //é adicionada o cancelamento da entrega
        }
    }
}